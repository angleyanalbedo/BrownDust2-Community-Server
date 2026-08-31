using System.Threading.Tasks;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Common.Utils;
using Bd2.Server.DAO.Game;
using Bd2.Server.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SqlSugar;

namespace Bd2.Server.Controllers.Game;

[Authorize]
[ApiController]
[Route("Game/[Action]")]
public class GuildController : ControllerBase
{
	private readonly ISqlSugarClient _db;

	public GuildController(ISqlSugarClient db) => _db = db;
	[HttpPut]
	public async Task<GameActionResult> GuildInfo([FromBody] string data)
	{
		var request = ProtoUtil.Deserialize<GuildInfoRequest>(data);
		long uid = long.Parse(base.User.FindFirst("user").Value);
		var member = await _db.Queryable<GuildUserInfoDao>().SingleAsync(x => x.Uid == uid);
		var response = new GuildInfoResponse { GuildInfo = new GuildDBInfo() };
		if (member != null && member.GuildId != 0 && (request.Id == 0 || request.Id == member.GuildId))
		{
			response.GuildInfo.GuildBaseInfo = new GuildBaseDBInfo { Id = member.GuildId };
			response.MemberInfo.Add(new GuildMemberDBInfo { OwnerIndex = uid, UserId = uid.ToString(), Role = (Define_GuildMemberRole)member.Role });
		}
		return ResultUtil.CreateResult(response);
	}

	[HttpPut]
	public async Task<GameActionResult> GuildRecommend([FromBody] string data)
	{
		var request = ProtoUtil.Deserialize<GuildRecommendRequest>(data);
		var response = new GuildRecommendResponse();
		var guilds = await _db.Queryable<GuildUserInfoDao>().Where(x => x.GuildId != 0).GroupBy(x => x.GuildId)
			.Select(x => new { GuildId = x.GuildId, MemberCount = SqlFunc.AggregateCount(x.Uid) }).ToListAsync();
		foreach (var guild in guilds)
		{
			if (request.SearchMin != 0 && guild.GuildId < request.SearchMin || request.SearchMax != 0 && guild.GuildId > request.SearchMax) continue;
			response.GuildInfo.Add(new GuildDBInfo { GuildBaseInfo = new GuildBaseDBInfo { Id = guild.GuildId }, JoinType = request.JoinType, MemberCount = guild.MemberCount });
		}
		return ResultUtil.CreateResult(response);
	}

	[HttpPut]
	public async Task<GameActionResult> GuildJoinSendInfo([FromBody] string data)
	{
		return await Task.FromResult(ResultUtil.CreateResult(new GuildJoinSendInfoResponse()));
	}
}
