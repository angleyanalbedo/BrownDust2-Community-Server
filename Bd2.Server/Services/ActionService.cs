using AutoMapper;
using Bd2.Server.Common.Enums;
using Bd2.Server.Common.Managers;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.iServices;
using Bd2.Server.DAO.Game;
using EasyTool;
using Microsoft.Extensions.Logging;
using SqlSugar;

namespace Bd2.Server.Services;

public class ActionService : IActionService
{
	private readonly ILogger<ActionService> _logger;

	private readonly ISqlSugarClient _db;

	private readonly IMapper _mapper;

	public ActionService(ILogger<ActionService> logger, ISqlSugarClient db, IMapper mapper)
	{
		_mapper = mapper;
		_db = db;
		_logger = logger;
	}

	private void AddFreeJewelry(int count, string uid)
	{
		(from x in _db.Updateable<UserInfoDao>().SetColumns((UserInfoDao x) => x.FreeJewelry == x.FreeJewelry + (long)count)
			where x.OwnerIndex == long.Parse(uid)
			select x).ExecuteCommand();
		_logger.LogInformation("Add FreeJewelry {}", uid);
	}

	private void AddGold(int count, string uid)
	{
		(from x in _db.Updateable<UserInfoDao>().SetColumns((UserInfoDao x) => x.Gold == x.Gold + (long)count)
			where x.OwnerIndex == long.Parse(uid)
			select x).ExecuteCommand();
	}

	private void AddBonusHuntingAP(int count, string uid)
	{
		(from x in _db.Updateable<UserInfoDao>().SetColumns((UserInfoDao x) => x.BonusHuntingAp == x.BonusHuntingAp + count)
			where x.OwnerIndex == long.Parse(uid)
			select x).ExecuteCommand();
	}

	private void AddTorchLightAP(int count, string uid)
	{
		(from x in _db.Updateable<UserInfoDao>().SetColumns((UserInfoDao x) => x.TorchLightAp == x.TorchLightAp + count)
			where x.OwnerIndex == long.Parse(uid)
			select x).ExecuteCommand();
	}

	public ItemDBInfo SendItemToUser(int itemId, int type, int count, string uid)
	{
		switch ((ItemType)type)
		{
		case ItemType.FreeJewelry:
			AddFreeJewelry(count, uid);
			break;
		case ItemType.Gold:
			AddGold(count, uid);
			break;
		case ItemType.BonusHuntingAP:
			AddBonusHuntingAP(count, uid);
			break;
		case ItemType.TorchLightAP:
			AddTorchLightAP(count, uid);
			break;
		}
		return new ItemDBInfo
		{
			Type = type,
			Count = count
		};
	}

	public ItemDBInfo SendItemToBag(int itemId, int type, int count, string uid)
	{
		_logger.LogWarning("发送道具 {} {} {}", type, itemId, count);
		var resolution = InventoryItemResolver.Resolve(type, itemId);
		if (!resolution.IsValid || resolution.Category == InventoryItemCategory.BossCostume ||
			(type == (int)ItemType.Costume && resolution.Category != InventoryItemCategory.PlayerCostume))
		{
			_logger.LogError("拒绝写入无效或不可作为玩家背包物品的数据: type={Type}, id={Id}, category={Category}",
				type, itemId, resolution.Category);
			return new ItemDBInfo { Type = type, Id = itemId, Count = 0 };
		}
		bool flag;
		switch ((ItemType)type)
		{
		case ItemType.Food:
		case ItemType.Resource:
		case ItemType.RandomBox:
		case ItemType.QuestItem:
		case ItemType.UseItem:
		case ItemType.MyRoomNormalItem:
			flag = true;
			break;
		default:
			flag = false;
			break;
		}
		if (flag)
		{
			ItemInfoDao itemInfoDao = _db.Queryable<ItemInfoDao>().First((ItemInfoDao x) => x.Id == itemId && x.Uid == long.Parse(uid));
			if (itemInfoDao == null)
			{
				itemInfoDao = new ItemInfoDao
				{
					Uid = long.Parse(uid),
					Id = itemId,
					Type = type,
					Count = count,
					TimeValue = TimerUtil.GetCurrentTimestamp()
				};
				itemInfoDao.InvenIndex = _db.Insertable(itemInfoDao).ExecuteReturnIdentity();
			}
			else
			{
				itemInfoDao.Count += count;
				_db.Updateable(itemInfoDao).ExecuteCommand();
				itemInfoDao.Count = count;
			}
			return _mapper.Map<ItemDBInfo>(itemInfoDao);
		}
		ItemSpecialInfoDao insertObj = new ItemSpecialInfoDao
		{
			Uid = long.Parse(uid),
			Id = itemId,
			Type = type,
			Count = count,
			ExpiryTime = 0L
		};
		ItemSpecialInfoDao source = _db.Insertable(insertObj).ExecuteReturnEntity();
		return _mapper.Map<ItemDBInfo>(source);
	}
}
