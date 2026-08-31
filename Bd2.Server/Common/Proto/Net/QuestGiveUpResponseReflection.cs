using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class QuestGiveUpResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXNwb25zZS9RdWVzdEdpdmVVcFJlc3BvbnNlLnByb3RvEglwcm90by5u" + "ZXQaGENvbW1vbnMvRGVja0RCSW5mby5wcm90bxoYQ29tbW9ucy9JdGVtREJJ" + "bmZvLnByb3RvIqQBChNRdWVzdEdpdmVVcFJlc3BvbnNlEhAKCHF1ZXN0X2lk" + "GAEgASgFEigKCWRlY2tfaW5mbxgCIAMoCzIVLnByb3RvLm5ldC5EZWNrREJJ" + "bmZvEjAKEXJlbW92ZV9xdWVzdF9pdGVtGAMgAygLMhUucHJvdG8ubmV0Lkl0" + "ZW1EQkluZm8SHwoXZGVsZXRlX2NoYXJfaW52ZW5faW5kZXgYBCADKANiBnBy" + "b3RvMw=="), new FileDescriptor[2]
	{
		DeckDBInfoReflection.Descriptor,
		ItemDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(QuestGiveUpResponse), QuestGiveUpResponse.Parser, new string[4] { "QuestId", "DeckInfo", "RemoveQuestItem", "DeleteCharInvenIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
