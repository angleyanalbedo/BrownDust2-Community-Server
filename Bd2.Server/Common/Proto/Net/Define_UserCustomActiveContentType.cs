using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_UserCustomActiveContentType
{
	[OriginalName("RUAC_PASS")]
	RuacPass = 0,
	[OriginalName("RUAC_EVENT_MISSION")]
	RuacEventMission = 1,
	[OriginalName("RUAC_GACHA")]
	RuacGacha = 2,
	[OriginalName("RUAC_CASH_SHOP")]
	RuacCashShop = 3,
	[OriginalName("RUAC_ALL")]
	RuacAll = 9999
}
