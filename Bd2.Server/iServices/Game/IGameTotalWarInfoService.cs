using Bd2.Server.iServices;
using Bd2.Server.Model;

namespace Bd2.Server.iServices.Game;

public interface IGameTotalWarInfoService : IBatchEndpointService
{
	GameActionResult TotalWarRewardState(string data, string uid);
}
