using System.Threading.Tasks;

namespace Bd2.Server.iServices.Game;

public interface IContentUnlockService
{
    Task<ContentUnlockResult> UnlockIndependentContentAsync(long uid);
}

public sealed record ContentUnlockResult(int Added, int Existing, int Skipped, int Invalid);
