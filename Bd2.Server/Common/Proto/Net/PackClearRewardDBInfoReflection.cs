using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PackClearRewardDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNDb21tb25zL1BhY2tDbGVhclJld2FyZERCSW5mby5wcm90bxIJcHJvdG8ubmV0Ik0KFVBhY2tDbGVhclJld2FyZERCSW5mbxIQCghncm91cF9pZBgBIAEoBRIRCgl0aWNrZXRfaWQYAiABKAUSDwoHcGFja19pZBgDIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackClearRewardDBInfo), PackClearRewardDBInfo.Parser, new string[3] { "GroupId", "TicketId", "PackId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
