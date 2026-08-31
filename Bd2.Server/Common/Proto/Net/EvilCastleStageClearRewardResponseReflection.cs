using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleStageClearRewardResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjFSZXNwb25zZS9FdmlsQ2FzdGxlU3RhZ2VDbGVhclJld2FyZFJlc3BvbnNl" + "LnByb3RvEglwcm90by5uZXQaGENvbW1vbnMvSXRlbURCSW5mby5wcm90bxoY" + "Q29tbW9ucy9DaGFyREJJbmZvLnByb3RvGhlDb21tb25zL0VxdWlwREJJbmZv" + "LnByb3RvGhtDb21tb25zL0Nvc3R1bWVEQkluZm8ucHJvdG8i1AEKIkV2aWxD" + "YXN0bGVTdGFnZUNsZWFyUmV3YXJkUmVzcG9uc2USKAoJaXRlbV9pbmZvGAEg" + "AygLMhUucHJvdG8ubmV0Lkl0ZW1EQkluZm8SKAoJY2hhcl9pbmZvGAIgAygL" + "MhUucHJvdG8ubmV0LkNoYXJEQkluZm8SKgoKZXF1aXBfaW5mbxgDIAMoCzIW" + "LnByb3RvLm5ldC5FcXVpcERCSW5mbxIuCgxjb3N0dW1lX2luZm8YBCADKAsy" + "GC5wcm90by5uZXQuQ29zdHVtZURCSW5mb2IGcHJvdG8z"), new FileDescriptor[4]
	{
		ItemDBInfoReflection.Descriptor,
		CharDBInfoReflection.Descriptor,
		EquipDBInfoReflection.Descriptor,
		CostumeDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleStageClearRewardResponse), EvilCastleStageClearRewardResponse.Parser, new string[4] { "ItemInfo", "CharInfo", "EquipInfo", "CostumeInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
