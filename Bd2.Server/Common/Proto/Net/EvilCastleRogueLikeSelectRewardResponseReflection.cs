using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRogueLikeSelectRewardResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjZSZXNwb25zZS9FdmlsQ2FzdGxlUm9ndWVMaWtlU2VsZWN0UmV3YXJkUmVz" + "cG9uc2UucHJvdG8SCXByb3RvLm5ldBoqQ29tbW9ucy9FdmlsQ2FzdGxlUm9n" + "dWVMaWtlU3RhdGVJbmZvLnByb3RvGitDb21tb25zL0V2aWxDYXN0bGVSb2d1" + "ZUxpa2VDaG9pY2VJbmZvLnByb3RvGhhDb21tb25zL0NoYXJEQkluZm8ucHJv" + "dG8aG0NvbW1vbnMvQ29zdHVtZURCSW5mby5wcm90bxoZQ29tbW9ucy9SZWxp" + "Y0RCSW5mby5wcm90bxopQ29tbW9ucy9FdmlsQ2FzdGxlUm9ndWVMaWtlUm9v" + "bUluZm8ucHJvdG8imgMKJ0V2aWxDYXN0bGVSb2d1ZUxpa2VTZWxlY3RSZXdh" + "cmRSZXNwb25zZRI7CgpzdGF0ZV9pbmZvGAEgASgLMicucHJvdG8ubmV0LkV2" + "aWxDYXN0bGVSb2d1ZUxpa2VTdGF0ZUluZm8SPQoLY2hvaWNlX2luZm8YAiAB" + "KAsyKC5wcm90by5uZXQuRXZpbENhc3RsZVJvZ3VlTGlrZUNob2ljZUluZm8S" + "KAoJY2hhcl9pbmZvGAMgAygLMhUucHJvdG8ubmV0LkNoYXJEQkluZm8SLgoM" + "Y29zdHVtZV9pbmZvGAQgASgLMhgucHJvdG8ubmV0LkNvc3R1bWVEQkluZm8S" + "KgoKcmVsaWNfaW5mbxgFIAEoCzIWLnByb3RvLm5ldC5SZWxpY0RCSW5mbxIT" + "CgtjbGVhcl9mbG9vchgGIAEoBRI/Cg9jbGVhcl9yb29tX2luZm8YByABKAsy" + "Ji5wcm90by5uZXQuRXZpbENhc3RsZVJvZ3VlTGlrZVJvb21JbmZvEhcKD3Jv" + "Z3VlX2xpa2VfZ29sZBgIIAEoBWIGcHJvdG8z"), new FileDescriptor[6]
	{
		EvilCastleRogueLikeStateInfoReflection.Descriptor,
		EvilCastleRogueLikeChoiceInfoReflection.Descriptor,
		CharDBInfoReflection.Descriptor,
		CostumeDBInfoReflection.Descriptor,
		RelicDBInfoReflection.Descriptor,
		EvilCastleRogueLikeRoomInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRogueLikeSelectRewardResponse), EvilCastleRogueLikeSelectRewardResponse.Parser, new string[8] { "StateInfo", "ChoiceInfo", "CharInfo", "CostumeInfo", "RelicInfo", "ClearFloor", "ClearRoomInfo", "RogueLikeGold" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
