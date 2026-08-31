using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldMonsterRewardResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilSZXNwb25zZS9GaWVsZE1vbnN0ZXJSZXdhcmRSZXNwb25zZS5wcm90bxIJ" + "cHJvdG8ubmV0GhhDb21tb25zL0l0ZW1EQkluZm8ucHJvdG8aGUNvbW1vbnMv" + "RXF1aXBEQkluZm8ucHJvdG8icgoaRmllbGRNb25zdGVyUmV3YXJkUmVzcG9u" + "c2USKAoJaXRlbV9pbmZvGAEgAygLMhUucHJvdG8ubmV0Lkl0ZW1EQkluZm8S" + "KgoKZXF1aXBfaW5mbxgCIAMoCzIWLnByb3RvLm5ldC5FcXVpcERCSW5mb2IG" + "cHJvdG8z"), new FileDescriptor[2]
	{
		ItemDBInfoReflection.Descriptor,
		EquipDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldMonsterRewardResponse), FieldMonsterRewardResponse.Parser, new string[2] { "ItemInfo", "EquipInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
