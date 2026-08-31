using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GachaScheduleDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFDb21tb25zL0dhY2hhU2NoZWR1bGVEQkluZm8ucHJvdG8SCXByb3RvLm5l" + "dCKTAQoTR2FjaGFTY2hlZHVsZURCSW5mbxIQCghncm91cF9pZBgBIAEoBRIS" + "CgpzdGFydF90aW1lGAIgASgDEhAKCGVuZF90aW1lGAMgASgDEiEKGWlzX2dh" + "Y2hhX2ZyZWVfY291bnRfYm9udXMYBCABKAgSIQoZaXNfZ2FjaGFfY2FzaF9j" + "b3VudF9ib251cxgFIAEoCGIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GachaScheduleDBInfo), GachaScheduleDBInfo.Parser, new string[5] { "GroupId", "StartTime", "EndTime", "IsGachaFreeCountBonus", "IsGachaCashCountBonus" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
