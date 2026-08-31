using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class StatueDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpDb21tb25zL1N0YXR1ZURCSW5mby5wcm90bxIJcHJvdG8ubmV0IoIBCgxTdGF0dWVEQkluZm8SCgoCaWQYASABKAUSDgoGc2Vhc29uGAIgASgFEhMKC3N0YXR1ZV9yYW5rGAMgASgFEhMKC293bmVyX2luZGV4GAQgASgFEg8KB3VzZXJfaWQYBSABKAkSGwoTcG9ydHJhaXRfY29zdHVtZV9pZBgGIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(StatueDBInfo), StatueDBInfo.Parser, new string[6] { "Id", "Season", "StatueRank", "OwnerIndex", "UserId", "PortraitCostumeId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
