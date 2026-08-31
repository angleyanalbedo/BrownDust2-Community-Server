using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class QuestLevelDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Db21tb25zL1F1ZXN0TGV2ZWxEQkluZm8ucHJvdG8SCXByb3RvLm5ldCJ7ChBRdWVzdExldmVsREJJbmZvEg8KB3BhY2tfaWQYASABKAUSEwoLcXVlc3RfbGV2ZWwYAiABKAUSEwoLY2xlYXJfcXVlc3QYAyABKAUSEQoJcXVlc3Rfb3B0GAQgASgFEhkKEWlzX2xldmVsX2NvbXBsZXRlGAUgASgIYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(QuestLevelDBInfo), QuestLevelDBInfo.Parser, new string[5] { "PackId", "QuestLevel", "ClearQuest", "QuestOpt", "IsLevelComplete" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
