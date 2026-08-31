using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class QuestClearRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXF1ZXN0L1F1ZXN0Q2xlYXJSZXF1ZXN0LnByb3RvEglwcm90by5uZXQiVgoRUXVlc3RDbGVhclJlcXVlc3QSCwoDc2VxGAEgASgFEhAKCHF1ZXN0X2lkGAIgASgFEg8KB3BhY2tfaWQYAyABKAUSEQoJcXVlc3Rfb3B0GAQgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(QuestClearRequest), QuestClearRequest.Parser, new string[4] { "Seq", "QuestId", "PackId", "QuestOpt" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
