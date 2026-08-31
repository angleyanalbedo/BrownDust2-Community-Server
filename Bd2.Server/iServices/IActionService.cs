using Bd2.Server.Common.Proto.Net;

namespace Bd2.Server.iServices;

public interface IActionService
{
	ItemDBInfo SendItemToUser(int itemId, int type, int count, string uid);

	ItemDBInfo SendItemToBag(int itemId, int type, int count, string uid);
}
