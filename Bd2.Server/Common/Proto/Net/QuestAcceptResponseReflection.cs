using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class QuestAcceptResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXNwb25zZS9RdWVzdEFjY2VwdFJlc3BvbnNlLnByb3RvEglwcm90by5u" + "ZXQaGENvbW1vbnMvQ2hhckRCSW5mby5wcm90bxoYQ29tbW9ucy9EZWNrREJJ" + "bmZvLnByb3RvGhlDb21tb25zL1F1ZXN0REJJbmZvLnByb3RvGhhDb21tb25z" + "L0l0ZW1EQkluZm8ucHJvdG8ixQEKE1F1ZXN0QWNjZXB0UmVzcG9uc2USKgoK" + "cXVlc3RfaW5mbxgBIAEoCzIWLnByb3RvLm5ldC5RdWVzdERCSW5mbxIoCglj" + "aGFyX2luZm8YAiADKAsyFS5wcm90by5uZXQuQ2hhckRCSW5mbxIoCglkZWNr" + "X2luZm8YAyADKAsyFS5wcm90by5uZXQuRGVja0RCSW5mbxIuCg9naXZlX3F1" + "ZXN0X2l0ZW0YBCADKAsyFS5wcm90by5uZXQuSXRlbURCSW5mb2IGcHJvdG8z"), new FileDescriptor[4]
	{
		CharDBInfoReflection.Descriptor,
		DeckDBInfoReflection.Descriptor,
		QuestDBInfoReflection.Descriptor,
		ItemDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(QuestAcceptResponse), QuestAcceptResponse.Parser, new string[4] { "QuestInfo", "CharInfo", "DeckInfo", "GiveQuestItem" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
