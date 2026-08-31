using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PackSubQuestClearInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CixSZXNwb25zZS9QYWNrU3ViUXVlc3RDbGVhckluZm9SZXNwb25zZS5wcm90" + "bxIJcHJvdG8ubmV0Il8KHVBhY2tTdWJRdWVzdENsZWFySW5mb1Jlc3BvbnNl" + "Ej4KFHN1Yl9xdWVzdF9jbGVhcl9pbmZvGAEgAygLMiAucHJvdG8ubmV0LlBh" + "Y2tTdWJRdWVzdENsZWFySW5mbyJHChVQYWNrU3ViUXVlc3RDbGVhckluZm8S" + "DwoHcGFja19pZBgBIAEoBRIdChVzdWJfcXVlc3RfY2xlYXJfY291bnQYAiAB" + "KAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[2]
	{
		new GeneratedClrTypeInfo(typeof(PackSubQuestClearInfoResponse), PackSubQuestClearInfoResponse.Parser, new string[1] { "SubQuestClearInfo" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(PackSubQuestClearInfo), PackSubQuestClearInfo.Parser, new string[2] { "PackId", "SubQuestClearCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
