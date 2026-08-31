using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_ContentTicketType
{
	[OriginalName("CONTENT_TICKET_NONE")]
	ContentTicketNone,
	[OriginalName("CONTENT_TICKET_OPEN_CONTENT")]
	ContentTicketOpenContent,
	[OriginalName("CONTENT_TICKET_MONTHLY_FEE")]
	ContentTicketMonthlyFee,
	[OriginalName("CONTENT_TICKET_ATTENDANCE_PACKAGE")]
	ContentTicketAttendancePackage
}
