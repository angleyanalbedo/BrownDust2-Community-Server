using Bd2.Server.Model;

namespace Bd2.Server.iServices;

public interface IBatchService
{
	bool TryDispatch(string path, string data, string uid, out GameActionResult result);
}
