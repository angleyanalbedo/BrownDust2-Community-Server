using System.Threading.Tasks;

namespace Bd2.Server.iServices.Game;

public interface IScheduleAdminService
{
    Task<ScheduleAdminResult> ActivateMonsterHuntAsync(int monsterHuntId, int season, int durationDays);
    Task<ScheduleAdminResult> ActivateConfiguredEventsAsync(int durationDays);
    Task<ScheduleAdminResult> ConfigureEventAsync(int eventType, int eventId, int eventSubId, int durationDays);
    Task<ScheduleAdminResult> ActivateGachaAsync(int gachaGroupRowId, int durationDays);
    Task<ScheduleAdminResult> DisableGachaAsync(int gachaGroupRowId);
}

public sealed record ScheduleAdminResult(bool Success, int Changed, string Message);
