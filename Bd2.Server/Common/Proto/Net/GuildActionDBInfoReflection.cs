using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildActionDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Db21tb25zL0d1aWxkQWN0aW9uREJJbmZvLnByb3RvEglwcm90by5uZXQa" + "FENvbW1vbnMvRGVmaW5lLnByb3RvIrgBChFHdWlsZEFjdGlvbkRCSW5mbxIr" + "CgR0eXBlGAEgASgOMh0ucHJvdG8ubmV0LkRlZmluZV9HdWlsZEFjdGlvbhIM" + "CgR0aW1lGAIgASgDEhAKCGd1aWxkX2lkGAMgASgDEhIKCmd1aWxkX25hbWUY" + "BCABKAkSEQoJaXNfbm90aWZ5GAUgASgIEi8KBHJvbGUYBiABKA4yIS5wcm90" + "by5uZXQuRGVmaW5lX0d1aWxkTWVtYmVyUm9sZWIGcHJvdG8z"), new FileDescriptor[1] { DefineReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildActionDBInfo), GuildActionDBInfo.Parser, new string[6] { "Type", "Time", "GuildId", "GuildName", "IsNotify", "Role" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
