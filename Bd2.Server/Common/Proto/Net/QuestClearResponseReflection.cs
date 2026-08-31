using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class QuestClearResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXNwb25zZS9RdWVzdENsZWFyUmVzcG9uc2UucHJvdG8SCXByb3RvLm5l" + "dBoYQ29tbW9ucy9JdGVtREJJbmZvLnByb3RvGhhDb21tb25zL0NoYXJEQklu" + "Zm8ucHJvdG8aGENvbW1vbnMvRGVja0RCSW5mby5wcm90bxoZQ29tbW9ucy9R" + "dWVzdERCSW5mby5wcm90bxoZQ29tbW9ucy9FcXVpcERCSW5mby5wcm90bxob" + "Q29tbW9ucy9Db3N0dW1lREJJbmZvLnByb3RvGh5Db21tb25zL1JlcHV0YXRp" + "b25EQkluZm8ucHJvdG8aHkNvbW1vbnMvUXVlc3RMZXZlbERCSW5mby5wcm90" + "bxoYQ29tbW9ucy9QYWNrREJJbmZvLnByb3RvGiBDb21tb25zL1Jld2FyZERC" + "SW5mb0J1bmRsZS5wcm90byKHBQoSUXVlc3RDbGVhclJlc3BvbnNlEjkKEnJl" + "d2FyZF9pbmZvX2J1bmRsZRgBIAEoCzIdLnByb3RvLm5ldC5SZXdhcmREQklu" + "Zm9CdW5kbGUSKgoKcXVlc3RfaW5mbxgCIAEoCzIWLnByb3RvLm5ldC5RdWVz" + "dERCSW5mbxIWCg5jbGVhcl9xdWVzdF9pZBgDIAEoBRIoCglkZWNrX2luZm8Y" + "BCADKAsyFS5wcm90by5uZXQuRGVja0RCSW5mbxIoCgljaGFyX2luZm8YBSAD" + "KAsyFS5wcm90by5uZXQuQ2hhckRCSW5mbxIuCg9naXZlX3F1ZXN0X2l0ZW0Y" + "BiADKAsyFS5wcm90by5uZXQuSXRlbURCSW5mbxIwChFyZW1vdmVfcXVlc3Rf" + "aXRlbRgHIAMoCzIVLnByb3RvLm5ldC5JdGVtREJJbmZvEjQKD3JlcHV0YXRp" + "b25faW5mbxgIIAMoCzIbLnByb3RvLm5ldC5SZXB1dGF0aW9uREJJbmZvEjUK" + "EHF1ZXN0X2xldmVsX2luZm8YCSABKAsyGy5wcm90by5uZXQuUXVlc3RMZXZl" + "bERCSW5mbxIfChdkZWxldGVfY2hhcl9pbnZlbl9pbmRleBgKIAMoAxIoCglw" + "YWNrX2luZm8YCyADKAsyFS5wcm90by5uZXQuUGFja0RCSW5mbxJAChllbmRp" + "bmdfcmV3YXJkX2luZm9fYnVuZGxlGAwgASgLMh0ucHJvdG8ubmV0LlJld2Fy" + "ZERCSW5mb0J1bmRsZRJCChtpbW1vcnRhbF9yZXdhcmRfaW5mb19idW5kbGUY" + "DSABKAsyHS5wcm90by5uZXQuUmV3YXJkREJJbmZvQnVuZGxlYgZwcm90bzM="), new FileDescriptor[10]
	{
		ItemDBInfoReflection.Descriptor,
		CharDBInfoReflection.Descriptor,
		DeckDBInfoReflection.Descriptor,
		QuestDBInfoReflection.Descriptor,
		EquipDBInfoReflection.Descriptor,
		CostumeDBInfoReflection.Descriptor,
		ReputationDBInfoReflection.Descriptor,
		QuestLevelDBInfoReflection.Descriptor,
		PackDBInfoReflection.Descriptor,
		RewardDBInfoBundleReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(QuestClearResponse), QuestClearResponse.Parser, new string[13]
		{
			"RewardInfoBundle", "QuestInfo", "ClearQuestId", "DeckInfo", "CharInfo", "GiveQuestItem", "RemoveQuestItem", "ReputationInfo", "QuestLevelInfo", "DeleteCharInvenIndex",
			"PackInfo", "EndingRewardInfoBundle", "ImmortalRewardInfoBundle"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
