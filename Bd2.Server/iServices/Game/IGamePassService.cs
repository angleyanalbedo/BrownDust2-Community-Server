using Bd2.Server.Model;

namespace Bd2.Server.iServices.Game;

public interface IGamePassService
{
	GameActionResult PassReward(string data, string uid);
	GameActionResult PassBuy(string data, string uid);
}
