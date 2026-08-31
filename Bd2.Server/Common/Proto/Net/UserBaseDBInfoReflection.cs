using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class UserBaseDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxDb21tb25zL1VzZXJCYXNlREJJbmZvLnByb3RvEglwcm90by5uZXQicwoOVXNlckJhc2VEQkluZm8SEwoLb3duZXJfaW5kZXgYASABKAMSGwoTcG9ydHJhaXRfY29zdHVtZV9pZBgCIAEoBRIPCgd1c2VyX2lkGAMgASgJEhAKCHRpdGxlX2lkGAQgASgFEgwKBGRhdGUYBSABKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(UserBaseDBInfo), UserBaseDBInfo.Parser, new string[5] { "OwnerIndex", "PortraitCostumeId", "UserId", "TitleId", "Date" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
