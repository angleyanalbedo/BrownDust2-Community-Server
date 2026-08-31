using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_AccessUserType
{
	[OriginalName("AU_NORMAL")]
	AuNormal,
	[OriginalName("AU_ADMIN")]
	AuAdmin,
	[OriginalName("AU_LOGIN_BLOCK")]
	AuLoginBlock,
	[OriginalName("AU_CHAT_BLOCK")]
	AuChatBlock,
	[OriginalName("AU_LEAVE_RESERVATION")]
	AuLeaveReservation,
	[OriginalName("AU_LEAVE_USER")]
	AuLeaveUser,
	[OriginalName("AU_PRESET")]
	AuPreset,
	[OriginalName("AU_DUMMY")]
	AuDummy,
	[OriginalName("AU_LOGIN_PERIOD_BLOCK")]
	AuLoginPeriodBlock,
	[OriginalName("AU_AUTO_WORK_PLACE_BLOCK")]
	AuAutoWorkPlaceBlock
}
