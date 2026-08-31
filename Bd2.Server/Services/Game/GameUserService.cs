using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Bd2.Server.Common.Managers;
using Bd2.Server.Common.Proto.Design.common;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Common.Utils;
using Bd2.Server.iServices;
using Bd2.Server.iServices.Game;
using Bd2.Server.DAO.Game;
using EasyTool;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SqlSugar;
using Bd2.Server.Model;

namespace Bd2.Server.Services.Game;

public class GameUserService : IGameUserService
{
	private readonly ILogger<GameUserService> _logger;

	private readonly ISqlSugarClient _db;

	private readonly IMapper _mapper;

	private readonly IActionService _actionService;

	public GameUserService(ISqlSugarClient db, ILogger<GameUserService> logger, IMapper mapper, IActionService accountService)
	{
		_mapper = mapper;
		_db = db;
		_logger = logger;
		_actionService = accountService;
	}

	[BatchEndpoint]
	public GameActionResult PersonalInfo(string data, string uid)
	{
		var response = new PersonalInfoResponse();
		var dao = _db.Queryable<PersonalInfoDao>().First(x => x.Uid == long.Parse(uid));
		if (dao != null)
		{
			response.PersonalInfo.Add(new PersonalDBInfo
			{
				Id = dao.TitleId,
				Title = dao.Introduce ?? ""
			});
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult TutorialInfo(string data, string uid)
	{
		var response = new TutorialInfoResponse();
		var rows = _db.Queryable<TutorialClearInfoDao>().Where(x => x.Uid == long.Parse(uid)).ToList();
		foreach (var row in rows)
		{
			response.TutorialClearId.Add(row.TutorialClearId);
		}
		return ResultUtil.CreateResult(response);
	}

	[BatchEndpoint]
	public GameActionResult PresetInfo(string data, string uid)
	{
		var rows = _db.Queryable<PresetInfoDao>().Where(x => x.Uid == long.Parse(uid)).ToList();
		var response = new PresetInfoResponse();
		foreach (var row in rows)
		{
			var preset = new PresetDBInfo
			{
				PresetName = row.PresetName,
				PresetResourceId = row.PresetResourceId,
				PresetResourceColor = row.PresetResourceColor,
				Slot = row.Slot
			};
			preset.DeckInfo.AddRange(JsonConvert.DeserializeObject<RepeatedField<PresetDeckDBInfo>>(row.DeckInfo));
			response.PresetInfo.Add(preset);
		}
		return ResultUtil.CreateResult(response);
	}

	private async void AddItem(string uid)
	{
		int[] obj = new int[59]
		{
			3, 4, 5, 6, 7, 8, 9, 10, 11, 12,
			13, 14, 15, 16, 17, 101, 102, 103, 104, 105,
			106, 111, 112, 113, 114, 115, 116, 121, 122, 123,
			124, 125, 126, 127, 201, 202, 203, 204, 205, 211,
			212, 213, 214, 221, 222, 223, 224, 301, 311, 321,
			401, 411, 421, 501, 511, 521, 601, 602, 603
		};
		List<ItemInfoDao> list = new List<ItemInfoDao>();
		int[] array = obj;
		foreach (int id in array)
		{
			list.Add(new ItemInfoDao
			{
				Uid = int.Parse(uid),
				Id = id,
				Type = 8,
				Count = 9999,
				TimeValue = TimestampUtil.GetCurrentTimestamp()
			});
		}
		await _db.Insertable(list).ExecuteCommandAsync();
	}

	public async Task<GameActionResult> JoinUser(string uid)
	{
		UserInfoDao userInfoDao = new UserInfoDao
		{
			OwnerIndex = long.Parse(uid),
			UserId = "Guest_" + uid,
			InvenSlot = 500,
			StorageSlot = 100,
			EquipSlot = 2000,
			LevelReward = 1,
			EquipStorageSlot = 100,
			FreeHuntingAp = 60,
			BonusHuntingAp = 90000,
			FreeTorchLightAp = 60,
			TorchLightAp = 90000,
			Catalyst = 9999999L,
			Gold = 10000000L,
			Jewelry = 9000000L,
			FreeJewelry = 9000000L,
			PresetSlot = 5,
			ReturnStatusEndTime = -32400000L,
			MyRoomSlot = 3,
			IsFirstGacha = 1,
			EventApFree = 5,
			JoinTime = TimestampUtil.GetCurrentTimestamp(),
			LoginDate = TimestampUtil.GetCurrentTimestamp(),
			NewbiePassStep = 1,
			RogueLikeAp = 3,
			TotalWarPresetSlot = 5
		};
		await _db.Insertable(userInfoDao).ExecuteCommandAsync();
		UserDBInfo userDbInfo = _mapper.Map<UserDBInfo>(userInfoDao);
		userDbInfo.UserKey = "CHANGE_ME";
		RewardDBInfoBundle rewardDbInfoBundle = RewardDBInfoBundle.Parser.ParseFrom(Convert.FromBase64String("CgwQZRgHIAE6BAgEEAEKGgjX+tQLEBsYDSABMJion5aSMjoGCAUQxeoBChMI2+GUhQEQARgOIAEwmKiflpIyCgYQARgZIAEKBRgEIJBOEisI/b+jSxDGMhiIAiABOIql/1NAAVABWIC7xvD//////wFiBAgBEB9ovfkDEisI/r+jSxDQMhi1ASABOIul/1NAAVABWIC7xvD//////wFiBAgBECBoofoDEjEI/7+jSxDaMhikASABOIyl/1NAAVABWIC7xvD//////wFiBAgCEAFiBAgBECFohfsDEisIgMCjSxDkMhigASABOI2l/1NAAVABWIC7xvD//////wFiBAgBECJo6fsDEjAIgcCjSxD6LhgHIAE4jqX/U0ABUAFYgLvG8P//////AWIECAIQCWIECAEQI2jF1QMSLgiCwKNLEAoYpAEgATiPpf9TQAFQAViAu8bw//////8BYgQIAhACYgQIARABaGUaFAiKpf9TEL35AyD9v6NLKgQIBxA9GhQIi6X/UxCh+gMg/r+jSyoECAcQPhoUCIyl/1MQhfsDIP+/o0sqBAgHED8aFAiNpf9TEOn7AyCAwKNLKgQIBxBAGhQIjqX/UxDF1QMggcCjSyoECAcQHBoSCI+l/1MQZSCCwKNLKgQIBxABMggQvfkDGAsgATIHEMYyGAYgATIIEKH6AxgLIAEyBxDQMhgGIAEyCBCF+wMYCyABMgcQ2jIYBiABMggQ6fsDGAsgATIHEOQyGAYgATIIEMXVAxgLIAEyBxD6LhgGIAEyBhBlGAsgATIGEAoYBiABMgYQZRgHIAEyBhAbGA0gATIGEAEYDiABMgYQARgZIAE="));
		RepeatedField<CharDBInfo> charDbInfos = rewardDbInfoBundle.CharInfo;
		RepeatedField<CostumeDBInfo> costumeDbInfos = rewardDbInfoBundle.CostumeInfo;
		for (int i = 0; i < charDbInfos.Count; i++)
		{
			CharTable charData = CharManager.GetCharData(charDbInfos[i].Id);
			CharInfoDao charInfoDao = new CharInfoDao
			{
				Uid = int.Parse(uid),
				Id = charDbInfos[i].Id,
				Hp = charDbInfos[i].Hp,
				Level = charDbInfos[i].Level,
				SolidarityReward = 1,
				TalentLevel = 1,
				ExpiryTime = -32400000L,
				ConnectPotentialCostume = charDbInfos[i].ConnectPotentialCostume,
				UniqueCharId = charData.UniqueCharId
			};
			int index = await _db.Insertable(charInfoDao).ExecuteReturnIdentityAsync();
			CostumeInfoDao insertObj = new CostumeInfoDao
			{
				Uid = int.Parse(uid),
				Id = costumeDbInfos[i].Id,
				UseChar = index
			};
			int executeReturnIdentity = await _db.Insertable(insertObj).ExecuteReturnIdentityAsync();
			charInfoDao.InvenIndex = index;
			charInfoDao.UseCostume = executeReturnIdentity;
			await _db.Updateable(charInfoDao).ExecuteCommandAsync();
			charDbInfos[i].InvenIndex = index;
			charDbInfos[i].UseCostume = executeReturnIdentity;
			costumeDbInfos[i].InvenIndex = executeReturnIdentity;
			costumeDbInfos[i].UseChar = index;
		}
		RepeatedField<ItemDBInfo> itemInfo = rewardDbInfoBundle.ItemInfo;
		foreach (ItemDBInfo t in itemInfo)
		{
			if (t.InvenIndex != 0L)
			{
				ItemInfoDao insertObj2 = new ItemInfoDao
				{
					Uid = int.Parse(uid),
					Count = t.Count,
					Type = t.Type,
					Id = t.Id,
					TimeValue = TimestampUtil.GetCurrentTimestamp()
				};
				t.InvenIndex = await _db.Insertable(insertObj2).ExecuteReturnIdentityAsync();
				continue;
			}
			if (t.Type != 4)
			{
				ItemSpecialInfoDao insertObj3 = new ItemSpecialInfoDao
				{
					Uid = int.Parse(uid),
					Id = t.Id,
					Type = t.Type,
					Count = t.Count
				};
				await _db.Insertable(insertObj3).ExecuteCommandAsync();
				continue;
			}
			break;
		}
		return ResultUtil.CreateResult(new JoinUserResponse
		{
			RewardInfoBundle = rewardDbInfoBundle,
			UserInfo = userDbInfo
		});
	}

	public async Task<GameActionResult> LoginUser(string uid)
	{
		UserInfoDao userInfoDao = await _db.Queryable<UserInfoDao>().SingleAsync((UserInfoDao it) => it.OwnerIndex == long.Parse(uid));
		if (userInfoDao == null)
		{
			return new GameActionResult
			{
				errorType = 1,
				packetCode = 3,
				data = ""
			};
		}
		var charCount = await _db.Queryable<CharInfoDao>().Where(x => x.Uid == long.Parse(uid)).CountAsync();
		if (charCount == 0)
		{
			_logger.LogWarning("LoginUser: uid={} has no characters, creating default chars", uid);
			await CreateDefaultChars(uid);
		}
		UserDBInfo userDBInfo = _mapper.Map<UserDBInfo>(userInfoDao);
		userDBInfo.UserKey = "CHANGE_ME";
		return ResultUtil.CreateResult(new LoginUserResponse
		{
			UserInfo = userDBInfo
		}, new Notify
		{
			NoticeLastSeq = 1
		});
	}

	private async Task CreateDefaultChars(string uid)
	{
		RewardDBInfoBundle rewardDbInfoBundle = RewardDBInfoBundle.Parser.ParseFrom(Convert.FromBase64String("CgwQZRgHIAE6BAgEEAEKGgjX+tQLEBsYDSABMJion5aSMjoGCAUQxeoBChMI2+GUhQEQARgOIAEwmKiflpIyCgYQARgZIAEKBRgEIJBOEisI/b+jSxDGMhiIAiABOIql/1NAAVABWIC7xvD//////wFiBAgBEB9ovfkDEisI/r+jSxDQMhi1ASABOIul/1NAAVABWIC7xvD//////wFiBAgBECBoofoDEjEI/7+jSxDaMhikASABOIyl/1NAAVABWIC7xvD//////wFiBAgCEAFiBAgBECFohfsDEisIgMCjSxDkMhigASABOI2l/1NAAVABWIC7xvD//////wFiBAgBECJo6fsDEjAIgcCjSxD6LhgHIAE4jqX/U0ABUAFYgLvG8P//////AWIECAIQCWIECAEQI2jF1QMSLgiCwKNLEAoYpAEgATiPpf9TQAFQAViAu8bw//////8BYgQIAhACYgQIARABaGUaFAiKpf9TEL35AyD9v6NLKgQIBxA9GhQIi6X/UxCh+gMg/r+jSyoECAcQPhoUCIyl/1MQhfsDIP+/o0sqBAgHED8aFAiNpf9TEOn7AyCAwKNLKgQIBxBAGhQIjqX/UxDF1QMggcCjSyoECAcQHBoSCI+l/1MQZSCCwKNLKgQIBxABMggQvfkDGAsgATIHEMYyGAYgATIIEKH6AxgLIAEyBxDQMhgGIAEyCBCF+wMYCyABMgcQ2jIYBiABMggQ6fsDGAsgATIHEOQyGAYgATIIEMXVAxgLIAEyBxD6LhgGIAEyBhBlGAsgATIGEAoYBiABMgYQZRgHIAEyBhAbGA0gATIGEAEYDiABMgYQARgZIAE="));
		RepeatedField<CharDBInfo> charDbInfos = rewardDbInfoBundle.CharInfo;
		RepeatedField<CostumeDBInfo> costumeDbInfos = rewardDbInfoBundle.CostumeInfo;
		for (int i = 0; i < charDbInfos.Count; i++)
		{
			CharTable charData = CharManager.GetCharData(charDbInfos[i].Id);
			if (charData == null) continue;
			CharInfoDao charInfoDao = new CharInfoDao
			{
				Uid = int.Parse(uid),
				Id = charDbInfos[i].Id,
				Hp = charDbInfos[i].Hp,
				Level = charDbInfos[i].Level,
				SolidarityReward = 1,
				TalentLevel = 1,
				ExpiryTime = -32400000L,
				ConnectPotentialCostume = charDbInfos[i].ConnectPotentialCostume,
				UniqueCharId = charData.UniqueCharId
			};
			int index = await _db.Insertable(charInfoDao).ExecuteReturnIdentityAsync();
			CostumeInfoDao insertObj = new CostumeInfoDao
			{
				Uid = int.Parse(uid),
				Id = costumeDbInfos[i].Id,
				UseChar = index
			};
			int executeReturnIdentity = await _db.Insertable(insertObj).ExecuteReturnIdentityAsync();
			charInfoDao.InvenIndex = index;
			charInfoDao.UseCostume = executeReturnIdentity;
			await _db.Updateable(charInfoDao).ExecuteCommandAsync();
		}
	}

	public async Task<GameActionResult> NoticeDetailInfo(int id)
	{
		NoticeInfoDao noticeInfoDao = await _db.Queryable<NoticeInfoDao>().SingleAsync((NoticeInfoDao it) => it.Id == id);
		NoticeDetailInfoResponse noticeDetailInfoResponse = new NoticeDetailInfoResponse();
		NoticeContentsInfo noticeContentsInfo = new NoticeContentsInfo();
		if (noticeInfoDao.NoticeContent != null)
		{
			noticeContentsInfo.Value = noticeInfoDao.NoticeContent;
		}
		noticeDetailInfoResponse.NoticeInfo = _mapper.Map<NoticeDBInfo>(noticeInfoDao);
		noticeDetailInfoResponse.NoticeInfo.NoticeContentsInfo.Add(noticeContentsInfo);
		return ResultUtil.CreateResult(noticeDetailInfoResponse);
	}

	public GameActionResult MailHistoryInfo(MailHistoryInfoRequest request, string uid)
	{
		long uidLong = long.Parse(uid);
		var query = _db.Queryable<MailInfoDao>()
			.Where(x => x.Uid == uidLong && x.InvenIndex > request.StartInvenIndex)
			.OrderBy(x => x.InvenIndex);
		var totalCount = query.Clone().Count();
		var mails = query.Take(request.SelectCount > 0 ? request.SelectCount : 100).ToList();
		var response = new MailHistoryInfoResponse { TotalCount = totalCount };
		foreach (var item in mails)
		{
			var mail = new MailDBInfo
			{
				InvenIndex = item.InvenIndex,
				Type = item.Type,
				MailId = item.MailId,
				RewardExpireTime = item.RewardExpireTime,
				IsOpen = item.IsOpen == 1,
				OpenTime = item.OpenTime,
				CreateTime = item.CreateTime,
				HistoryDeleteTime = item.HistoryDeleteTime,
				IsCash = item.IsCash == 1
			};
			if (item.SenderText != null) mail.SenderText = item.SenderText;
			if (item.TitleText != null) mail.TitleText = item.TitleText;
			if (item.MessageText != null) mail.MessageText = item.MessageText;
			mail.ItemId.Add(item.ItemId);
			mail.ItemType.Add(item.ItemType);
			mail.ItemCount.Add(item.ItemCount);
			response.MailInfo.Add(mail);
		}
		return ResultUtil.CreateResult(response);
	}

	public async Task<GameActionResult> ActiveMap(ActiveMapRequest map, string uid)
	{
		MapActiveInfoDao data = new MapActiveInfoDao
		{
			Uid = long.Parse(uid),
			PackId = map.PackId,
			MapId = map.MapId,
			Active = JsonConvert.SerializeObject(map.ActiveInfo)
		};
		await _db.Storageable(data).WhereColumns((MapActiveInfoDao it) => new { it.Uid, it.PackId, it.MapId }).ExecuteCommandAsync();
		return ResultUtil.CreateResult(new ActiveMapResponse());
	}

	public async Task<GameActionResult> SaveUserPosition(SaveUserPositionRequest position, string uid)
	{
		PositionInfoDao positionInfoDao = new PositionInfoDao
		{
			Uid = long.Parse(uid),
			PackId = position.PackId,
			Position = position.PackPosition
		};
		PositionInfoDao positionInfoDao2 = await _db.Queryable<PositionInfoDao>().SingleAsync((PositionInfoDao it) => it.Uid == long.Parse(uid) && it.PackId == position.PackId);
		if (positionInfoDao2 == null)
		{
			await _db.Insertable(positionInfoDao).ExecuteCommandAsync();
		}
		else
		{
			positionInfoDao2.Position = position.PackPosition;
			await _db.Updateable(positionInfoDao2).ExecuteCommandAsync();
		}
		return ResultUtil.CreateResult(new SaveUserPositionResponse());
	}

	public async Task<GameActionResult> DeckSave(DeckSaveRequest deck, string uid)
	{
		long uidLong = long.Parse(uid);
		await (from it in _db.Deleteable<DeckInfoDao>()
			where it.Uid == uidLong
			select it).ExecuteCommandAsync();
		List<DeckInfoDao> list = new List<DeckInfoDao>();
		foreach (DeckDBInfo item2 in deck.DeckInfo)
		{
			DeckInfoDao item = new DeckInfoDao
			{
				Uid = uidLong,
				Sequence = item2.Sequence,
				CharInvenIndex = item2.CharInvenIndex,
				Position = item2.Position
			};
			list.Add(item);
		}
		await _db.Insertable(list).ExecuteCommandAsync();
		var response = new DeckSaveResponse();
		if (list.Count > 0)
		{
			response.DeckInfo = _mapper.Map<DeckDBInfo>(list[0]);
		}
		var charInfoDao = _db.Queryable<CharInfoDao>().First(x => x.Uid == uidLong);
		if (charInfoDao != null)
		{
			response.CharInfo = _mapper.Map<CharDBInfo>(charInfoDao);
		}
		return ResultUtil.CreateResult(response);
	}

	public async Task<GameActionResult> TutorialClear(TutorialClearRequest tutorial, string uid)
	{
		TutorialClearInfoDao insertObj = new TutorialClearInfoDao
		{
			Uid = long.Parse(uid),
			TutorialClearId = tutorial.ClearTutorialId
		};
		await _db.Insertable(insertObj).ExecuteCommandAsync();
		return ResultUtil.CreateResult(new TutorialClearResponse());
	}

	public async Task<GameActionResult> PresetSave(PresetSaveRequest req, string uid)
	{
		_logger.LogInformation("预设保存 {}", req);
		PresetInfoDao presetInfoDao = await _db.Queryable<PresetInfoDao>().SingleAsync((PresetInfoDao x) => x.Uid == long.Parse(uid) && x.Slot == req.PresetInfo.Slot);
		if (presetInfoDao == null)
		{
			PresetInfoDao insertObj = new PresetInfoDao
			{
				Uid = long.Parse(uid),
				Slot = req.PresetInfo.Slot,
				PresetName = req.PresetInfo.PresetName,
				PresetResourceId = req.PresetInfo.PresetResourceId,
				PresetResourceColor = req.PresetInfo.PresetResourceColor,
				DeckInfo = JsonConvert.SerializeObject(req.PresetInfo.DeckInfo)
			};
			await _db.Insertable(insertObj).ExecuteCommandAsync();
		}
		else
		{
			presetInfoDao.PresetName = req.PresetInfo.PresetName;
			presetInfoDao.PresetResourceId = req.PresetInfo.PresetResourceId;
			presetInfoDao.PresetResourceColor = req.PresetInfo.PresetResourceColor;
			presetInfoDao.DeckInfo = JsonConvert.SerializeObject(req.PresetInfo.DeckInfo);
			await _db.Updateable(presetInfoDao).ExecuteCommandAsync();
		}
		return ResultUtil.CreateResult(new PresetSaveResponse());
	}

	public async Task<GameActionResult> PresetInfoChange(PresetInfoChangeRequest req, string uid)
	{
		_logger.LogInformation("预设修改 {}", req);
		await (from x in _db.Updateable<PresetInfoDao>().SetColumns((PresetInfoDao x) => x.PresetName == req.PresetName).SetColumns((PresetInfoDao x) => x.PresetResourceId == req.PresetResourceId)
				.SetColumns((PresetInfoDao x) => x.PresetResourceColor == req.PresetResourceColor)
				.SetColumns((PresetInfoDao x) => x.Slot == req.Slot)
			where x.Uid == long.Parse(uid) && x.Slot == req.Slot
			select x).ExecuteCommandAsync();
		return ResultUtil.CreateResult(new PresetInfoChangeResponse());
	}

	public async Task<GameActionResult> PresetDelete(PresetDeleteRequest req, string uid)
	{
		foreach (int slot in req.Slot)
		{
			await (from x in _db.Deleteable<PresetInfoDao>()
				where x.Slot == slot && x.Uid == long.Parse(uid)
				select x).ExecuteCommandAsync();
		}
		return ResultUtil.CreateResult(new PresetDeleteResponse());
	}

	public async Task<GameActionResult> WaypointSave(WaypointSaveRequest req, string uid)
	{
		WayPointInfoDao wayPointInfoDao = await _db.Queryable<WayPointInfoDao>().SingleAsync((WayPointInfoDao it) => it.Uid == long.Parse(uid) && it.PackId == req.PackId);
		if (wayPointInfoDao == null)
		{
			List<int> list = new List<int>();
			list.Add(req.WaypointId);
			WayPointInfoDao insertObj = new WayPointInfoDao
			{
				Uid = long.Parse(uid),
				PackId = req.PackId,
				PointId = JsonConvert.SerializeObject(list)
			};
			await _db.Insertable(insertObj).ExecuteCommandAsync();
		}
		else
		{
			List<int> list2 = JsonConvert.DeserializeObject<List<int>>(wayPointInfoDao.PointId);
			list2.Add(req.WaypointId);
			wayPointInfoDao.PointId = JsonConvert.SerializeObject(list2);
			await _db.Updateable(wayPointInfoDao).ExecuteCommandAsync();
		}
		return ResultUtil.CreateResult(new WaypointSaveResponse());
	}

	public async Task<GameActionResult> PackPreviewInfo(PackPreviewInfoRequest req, string uid)
	{
		QuestInfoDao questInfoDao = await _db.Queryable<QuestInfoDao>().SingleAsync((QuestInfoDao x) => x.Uid == long.Parse(uid) && x.PackId == req.PackId);
		PackPreviewInfoResponse packPreviewInfoResponse = new PackPreviewInfoResponse();
		if (questInfoDao != null)
		{
			List<int> source = JsonConvert.DeserializeObject<List<int>>(questInfoDao.QuestClear);
			packPreviewInfoResponse.QuestInfo.Add(new QuestDBInfo
			{
				Id = questInfoDao.QuestId
			});
			packPreviewInfoResponse.QuestTitleInfo.Add(new QuestTitleDBInfo
			{
				TitleId = 1,
				MaxClearId = source.Max()
			});
		}
		return ResultUtil.CreateResult(packPreviewInfoResponse);
	}

	public async Task<GameActionResult> MonsterInfo(MonsterInfoRequest req, string uid)
	{
		UserInfoDao userInfoDao = await _db.Queryable<UserInfoDao>().SingleAsync((UserInfoDao x) => x.OwnerIndex == long.Parse(uid));
		MonsterInfoResponse monsterInfoResponse = new MonsterInfoResponse();
		if (userInfoDao.LastPlayPackId < 1010)
		{
			List<MonsterDBInfo> monsterInfoListByGroupIds = BattleDeckManager.GetMonsterInfoListByGroupIds(userInfoDao.LastPlayPackId, req.GroupId.ToArray());
			monsterInfoResponse.MonsterInfo.AddRange(monsterInfoListByGroupIds);
		}
		return ResultUtil.CreateResult(monsterInfoResponse);
	}

	public async Task<GameActionResult> UseRandomBox(UseRandomBoxRequest req, string uid)
	{
		ItemInfoDao itemInfoDao = await _db.Queryable<ItemInfoDao>().SingleAsync((ItemInfoDao x) => x.InvenIndex == req.InvenIndex);
		RewardGroupTable rewardGroupTableByRandomBoxId = RewardManager.GetRewardGroupTableByRandomBoxId(itemInfoDao.Id);
		RewardDBInfoBundle rewardDbInfoBundle = new RewardDBInfoBundle();
		if (rewardGroupTableByRandomBoxId.ItemCount.Count != 0)
		{
			new List<ItemDBInfo>();
			List<ItemDBInfo> list = ((rewardGroupTableByRandomBoxId.DropType != 1) ? Bd2.Server.Common.Utils.RandomUtil.GetRollItemList(rewardGroupTableByRandomBoxId, req.UseCount) : Bd2.Server.Common.Utils.RandomUtil.GetAllItemList(rewardGroupTableByRandomBoxId, req.UseCount));
			foreach (ItemDBInfo item2 in list)
			{
				rewardDbInfoBundle.ViewItemInfo.Add(item2);
				ItemDBInfo item = _actionService.SendItemToBag(item2.Id, item2.Type, item2.Count, uid);
				rewardDbInfoBundle.ItemInfo.Add(item);
			}
		}
		itemInfoDao.Count -= req.UseCount;
		await _db.Updateable(itemInfoDao).ExecuteCommandAsync();
		return ResultUtil.CreateResult(new UseRandomBoxResponse
		{
			RewardInfoBundle = rewardDbInfoBundle
		});
	}

	public async Task<GameActionResult> HuntDispatch(HuntDispatchRequest req, string uid)
	{
		List<ItemDBInfo> rewardByHuntDispatch = HuntDispatchManager.GetRewardByHuntDispatch(req.HuntDispatchGroupId, req.HuntDispatchId, req.Count);
		RewardDBInfoBundle rewardDbInfoBundle = new RewardDBInfoBundle();
		foreach (ItemDBInfo item2 in rewardByHuntDispatch)
		{
			new ItemDBInfo();
			ItemDBInfo item = ((item2.Type > 4) ? _actionService.SendItemToBag(item2.Id, item2.Type, item2.Count, uid) : _actionService.SendItemToUser(item2.Id, item2.Type, item2.Count, uid));
			rewardDbInfoBundle.ItemInfo.Add(item);
			rewardDbInfoBundle.ViewItemInfo.Add(item2);
		}
		UserInfoDao userInfoDao = await _db.Queryable<UserInfoDao>().SingleAsync((UserInfoDao x) => x.OwnerIndex == long.Parse(uid));
		int num = 6 * req.Count;
		if (req != null && req.HuntDispatchGroupId == 2 && req.HuntDispatchId >= 7)
		{
			userInfoDao.FreeTorchLightAp -= num;
			if (userInfoDao.FreeTorchLightAp < 0)
			{
				userInfoDao.TorchLightAp += userInfoDao.FreeTorchLightAp;
				userInfoDao.FreeTorchLightAp = 0;
			}
		}
		else
		{
			userInfoDao.FreeHuntingAp -= num;
			if (userInfoDao.FreeHuntingAp < 0)
			{
				userInfoDao.BonusHuntingAp += userInfoDao.FreeHuntingAp;
				userInfoDao.FreeHuntingAp = 0;
			}
		}
		await _db.Updateable(userInfoDao).ExecuteCommandAsync();
		return ResultUtil.CreateResult(new HuntDispatchResponse
		{
			RewardInfoBundle = rewardDbInfoBundle
		});
	}

	public async Task<GameActionResult> ChargeCostInfo(string uid)
	{
		UserInfoDao userInfoDao = await _db.Queryable<UserInfoDao>().SingleAsync((UserInfoDao x) => x.OwnerIndex == long.Parse(uid));
		return ResultUtil.CreateResult(new ChargeCostInfoResponse
		{
			CostTimeInfo = 
			{
				new CostTimeDBInfo
				{
					LastChargeTime = 0L,
					CostItemInfo = new ItemDBInfo
					{
						Type = 21,
						Count = userInfoDao.FreeHuntingAp
					}
				},
				new CostTimeDBInfo
				{
					LastChargeTime = 0L,
					CostItemInfo = new ItemDBInfo
					{
						Type = 32,
						Count = userInfoDao.FreeTorchLightAp
					}
				},
				new CostTimeDBInfo
				{
					LastChargeTime = 0L,
					CostItemInfo = new ItemDBInfo
					{
						Type = 15,
						Count = userInfoDao.PvpTicket
					}
				}
			}
		});
	}

	public async Task<GameActionResult> MailOpen(MailOpenRequest req)
	{
		_logger.LogInformation("领取邮件 {}", req);
		long[] array = req.InvenIndex.ToArray();
		List<MailInfoDao> list = await (from x in _db.Queryable<MailInfoDao>()
			where array.Contains(x.InvenIndex)
			select x).ToListAsync();
		RewardDBInfoBundle rewardDbInfoBundle = new RewardDBInfoBundle();
		foreach (MailInfoDao item2 in list)
		{
			new ItemDBInfo();
			item2.IsOpen = 1;
			int itemType = item2.ItemType;
			bool flag = ((itemType <= 4 || itemType == 23 || itemType == 33) ? true : false);
			ItemDBInfo item = ((!flag) ? _actionService.SendItemToBag(item2.ItemId, item2.ItemType, item2.ItemCount, item2.Uid.ToString()) : _actionService.SendItemToUser(item2.ItemId, item2.ItemType, item2.ItemCount, item2.Uid.ToString()));
			rewardDbInfoBundle.ItemInfo.Add(item);
		}
		await _db.Updateable(list).ExecuteCommandAsync();
		return ResultUtil.CreateResult(new MailOpenResponse
		{
			RewardInfoBundle = rewardDbInfoBundle
		});
	}

	public async Task<GameActionResult> UserPortraitChange(UserPortraitChangeRequest req, string uid)
	{
		var uidLong = long.Parse(uid);
		var userInfo = await _db.Queryable<UserInfoDao>().SingleAsync(x => x.OwnerIndex == uidLong);
		if (userInfo == null)
		{
			return ResultUtil.CreateResult(new UserPortraitChangeResponse());
		}
		userInfo.PortraitCostumeId = req.PortraitCostumeId;
		await _db.Updateable(userInfo).ExecuteCommandAsync();
		return ResultUtil.CreateResult(new UserPortraitChangeResponse());
	}
}
