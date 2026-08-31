using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class SeasonRewardDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBDb21tb25zL1NlYXNvblJld2FyZERCSW5mby5wcm90bxIJcHJvdG8ubmV0IlEKElNlYXNvblJld2FyZERCSW5mbxIPCgdwYWNrX2lkGAEgASgFEg4KBnNlYXNvbhgCIAEoBRIaChJpc19yZXdhcmRfcmVjZWl2ZWQYAyABKAhiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(SeasonRewardDBInfo), SeasonRewardDBInfo.Parser, new string[3] { "PackId", "Season", "IsRewardReceived" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
