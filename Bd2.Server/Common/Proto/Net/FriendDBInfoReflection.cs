using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FriendDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpDb21tb25zL0ZyaWVuZERCSW5mby5wcm90bxIJcHJvdG8ubmV0Gh1Db21t" + "b25zL0d1aWxkQmFzZURCSW5mby5wcm90byKmAQoMRnJpZW5kREJJbmZvEhMK" + "C293bmVyX2luZGV4GAEgASgDEhsKE3BvcnRyYWl0X2Nvc3R1bWVfaWQYAiAB" + "KAUSDwoHdXNlcl9pZBgDIAEoCRIQCgh0aXRsZV9pZBgEIAEoBRIMCgRkYXRl" + "GAUgASgDEjMKD2d1aWxkX2Jhc2VfaW5mbxgGIAEoCzIaLnByb3RvLm5ldC5H" + "dWlsZEJhc2VEQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { GuildBaseDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FriendDBInfo), FriendDBInfo.Parser, new string[6] { "OwnerIndex", "PortraitCostumeId", "UserId", "TitleId", "Date", "GuildBaseInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
