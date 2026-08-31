using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GachaSelectionDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJDb21tb25zL0dhY2hhU2VsZWN0aW9uREJJbmZvLnByb3RvEglwcm90by5uZXQiRwoUR2FjaGFTZWxlY3Rpb25EQkluZm8SEAoIZ3JvdXBfaWQYASABKAUSDAoEc2xvdBgCIAEoBRIPCgdpdGVtX2lkGAMgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GachaSelectionDBInfo), GachaSelectionDBInfo.Parser, new string[3] { "GroupId", "Slot", "ItemId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
