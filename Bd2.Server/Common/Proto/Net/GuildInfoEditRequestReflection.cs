using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildInfoEditRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXF1ZXN0L0d1aWxkSW5mb0VkaXRSZXF1ZXN0LnByb3RvEglwcm90by5u" + "ZXQaFENvbW1vbnMvRGVmaW5lLnByb3RvIooBChRHdWlsZEluZm9FZGl0UmVx" + "dWVzdBILCgNzZXEYASABKAUSDAoEaWNvbhgCIAEoBRISCgppY29uX2NvbG9y" + "GAMgASgJEg8KB21lc3NhZ2UYBCABKAkSMgoJam9pbl90eXBlGAUgASgOMh8u" + "cHJvdG8ubmV0LkRlZmluZV9HdWlsZEpvaW5UeXBlYgZwcm90bzM="), new FileDescriptor[1] { DefineReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildInfoEditRequest), GuildInfoEditRequest.Parser, new string[5] { "Seq", "Icon", "IconColor", "Message", "JoinType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
