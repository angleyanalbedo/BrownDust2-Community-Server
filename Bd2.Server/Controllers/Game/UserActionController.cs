using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Common.Utils;
using Bd2.Server.DAO.Game;
using Bd2.Server.iServices.Game;
using Bd2.Server.Model;
using Google.Protobuf.Collections;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SqlSugar;

namespace Bd2.Server.Controllers.Game;

/// <summary>Handles user-initiated gameplay actions that change or consume user state.</summary>
[ApiController]
[Authorize]
[Route("Game/[Action]")]
public class UserActionController : ControllerBase
{
	private readonly ILogger<UserActionController> _logger;
	private readonly ISqlSugarClient _db;
	private readonly IGameUserService _gameUserService;
	private readonly IMapper _mapper;

	public UserActionController(ILogger<UserActionController> logger, ISqlSugarClient db, IGameUserService gameUserService, IMapper mapper)
	{
		_logger = logger;
		_db = db;
		_gameUserService = gameUserService;
		_mapper = mapper;
	}

	[HttpPut]
	public GameActionResult UpdateAgeGate([FromBody] string data)
	{
		var request = ProtoUtil.Deserialize<UpdateAgeGateRequest>(data);
		var uid = long.Parse(User.FindFirst("user").Value);
		var row = new AgeGateInfoDao
		{
			Uid = uid,
			IsJp = request.IsJp ? 1 : 0,
			Year = request.Year,
			Month = request.Month,
			Day = request.Day
		};
		if (_db.Queryable<AgeGateInfoDao>().Any(x => x.Uid == uid))
			_db.Updateable(row).ExecuteCommand();
		else
			_db.Insertable(row).ExecuteCommand();
		_logger.LogInformation("UpdateAgeGate: uid={Uid}, isJp={IsJp}, date={Year:D4}-{Month:D2}-{Day:D2}", uid, request.IsJp, request.Year, request.Month, request.Day);
		return ResultUtil.CreateResult(new UpdateAgeGateResponse());
	}

	[HttpPut]
	public GameActionResult PackBuy([FromBody] string data)
	{
		PackBuyRequest request = ProtoUtil.Deserialize<PackBuyRequest>(data);
		return ResultUtil.CreateResult(new PackBuyResponse { PackInfo = new PackDBInfo { Id = request.PackId } });
	}

	[HttpPut]
	public async Task<GameActionResult> UserPortraitChange([FromBody] string data)
	{
		var request = ProtoUtil.Deserialize<UserPortraitChangeRequest>(data);
		return await _gameUserService.UserPortraitChange(request, User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> TutorialClear([FromBody] string data)
	{
		TutorialClearRequest request = ProtoUtil.Deserialize<TutorialClearRequest>(data);
		return await _gameUserService.TutorialClear(request, User.FindFirst("user").Value);
	}

	[HttpPut]
	public GameActionResult Cooking()
	{
		CookingResponse response = new CookingResponse { AddTalentExp = 1 };
		response.ItemInfo.Add(new ItemDBInfo { Count = 1, Id = 2002, InvenIndex = 38617900L, Type = 5, TimeValue = 1722972375000L });
		return ResultUtil.CreateResult(response);
	}

	[HttpPut]
	public GameActionResult TrapDamage([FromBody] string data)
	{
		var request = ProtoUtil.Deserialize<TrapDamageRequest>(data);
		long uid = long.Parse(User.FindFirst("user").Value);
		var chars = _db.Queryable<CharInfoDao>().Where(x => x.Uid == uid).ToList();
		var response = new TrapDamageResponse();
		response.CharInfo.AddRange(_mapper.Map<List<CharDBInfo>>(chars));
		_logger.LogInformation("TrapDamage: trapId={TrapId}, charCount={Count}", request.TrapId, chars.Count);
		return ResultUtil.CreateResult(response);
	}

	[HttpPut]
	public GameActionResult CharImmortal([FromBody] string data)
	{
		CharImmortalRequest request = ProtoUtil.Deserialize<CharImmortalRequest>(data);
		List<CharInfoDao> chars = _db.Queryable<CharInfoDao>().In<RepeatedField<long>>(request.InvenIndex).ToList();
		CharImmortalResponse response = new CharImmortalResponse();
		response.CharInfo.AddRange(_mapper.Map<List<CharDBInfo>>(chars));
		return ResultUtil.CreateResult(response);
	}

	[HttpPut]
	public GameActionResult EatFood([FromBody] string data)
	{
		EatFoodRequest request = ProtoUtil.Deserialize<EatFoodRequest>(data);
		CharInfoDao character = _db.Queryable<CharInfoDao>().Single(x => x.InvenIndex == request.InvenIndex);
		EatFoodResponse response = new EatFoodResponse();
		response.CharInfo.Add(_mapper.Map<CharDBInfo>(character));
		return ResultUtil.CreateResult(response);
	}

	[HttpPut]
	public GameActionResult EatFoodAuto([FromBody] string data)
	{
		EatFoodAutoRequest request = ProtoUtil.Deserialize<EatFoodAutoRequest>(data);
		List<EatFoodAutoResponse.Types.RecoveryCharInfo> recoveryInfo = new List<EatFoodAutoResponse.Types.RecoveryCharInfo>();
		foreach (var foodUseInfo in request.EatFoodInfo)
		{
			CharInfoDao character = _db.Queryable<CharInfoDao>().Single(x => x.InvenIndex == foodUseInfo.InvenIndex);
			recoveryInfo.Add(new EatFoodAutoResponse.Types.RecoveryCharInfo { CharInvenIndex = character.InvenIndex, Hp = character.Hp });
		}
		EatFoodAutoResponse response = new EatFoodAutoResponse();
		response.RecoveryCharInfo.AddRange(recoveryInfo);
		return ResultUtil.CreateResult(response);
	}

	[HttpPut]
	public GameActionResult InnOpen()
	{
		return ResultUtil.CreateResult(new InnOpenResponse { ReputationState = 1 });
	}

	[HttpPut]
	public GameActionResult CharAllRevival([FromBody] string data)
	{
		CharAllRevivalRequest request = ProtoUtil.Deserialize<CharAllRevivalRequest>(data);
		List<CharInfoDao> chars = _db.Queryable<CharInfoDao>().In<RepeatedField<long>>(request.CharIndex).ToList();
		CharAllRevivalResponse response = new CharAllRevivalResponse();
		response.CharInfo.AddRange(_mapper.Map<List<CharDBInfo>>(chars));
		return ResultUtil.CreateResult(response);
	}

	[HttpPut]
	public async Task<GameActionResult> UseRandomBox([FromBody] string data)
	{
		UseRandomBoxRequest request = ProtoUtil.Deserialize<UseRandomBoxRequest>(data);
		return await _gameUserService.UseRandomBox(request, User.FindFirst("user").Value);
	}

	[HttpPut]
	public async Task<GameActionResult> MailOpen([FromBody] string data)
	{
		MailOpenRequest request = ProtoUtil.Deserialize<MailOpenRequest>(data);
		return await _gameUserService.MailOpen(request);
	}
}
