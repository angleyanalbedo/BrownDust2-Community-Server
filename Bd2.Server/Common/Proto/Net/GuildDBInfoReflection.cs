using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlDb21tb25zL0d1aWxkREJJbmZvLnByb3RvEglwcm90by5uZXQaFENvbW1v" + "bnMvRGVmaW5lLnByb3RvGh1Db21tb25zL0d1aWxkQmFzZURCSW5mby5wcm90" + "byLfAQoLR3VpbGREQkluZm8SMwoPZ3VpbGRfYmFzZV9pbmZvGAEgASgLMhou" + "cHJvdG8ubmV0Lkd1aWxkQmFzZURCSW5mbxIyCglqb2luX3R5cGUYAiABKA4y" + "Hy5wcm90by5uZXQuRGVmaW5lX0d1aWxkSm9pblR5cGUSDwoHbWVzc2FnZRgD" + "IAEoCRITCgt1cGRhdGVfZGF0ZRgEIAEoAxIMCgRkYXRlGAUgASgDEhQKDG1l" + "bWJlcl9jb3VudBgGIAEoBRIdChVkZWxldGVfcmVtYWluaW5nX3RpbWUYByAB" + "KANiBnByb3RvMw=="), new FileDescriptor[2]
	{
		DefineReflection.Descriptor,
		GuildBaseDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildDBInfo), GuildDBInfo.Parser, new string[7] { "GuildBaseInfo", "JoinType", "Message", "UpdateDate", "Date", "MemberCount", "DeleteRemainingTime" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
