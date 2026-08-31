using Bd2.Server.Model;
using Bd2.Server.iServices;

namespace Bd2.Server.iServices.Game;

public interface IGameMasterTitleService : IBatchEndpointService
{
	GameActionResult MasterTitleInfo(string data, string uid);

	GameActionResult MasterTitleInfoUpdate(string data, string uid);
}
