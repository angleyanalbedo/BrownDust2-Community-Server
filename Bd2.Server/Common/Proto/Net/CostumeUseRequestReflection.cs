using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CostumeUseRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXF1ZXN0L0Nvc3R1bWVVc2VSZXF1ZXN0LnByb3RvEglwcm90by5uZXQi" + "OwoOQ29zdHVtZVVzZUluZm8SFQoNY29zdHVtZV9pbmRleBgBIAEoAxISCgpj" + "aGFyX2luZGV4GAIgASgDImoKEUNvc3R1bWVVc2VSZXF1ZXN0EgsKA3NlcRgB" + "IAEoBRIzChBjb3N0dW1lX3VzZV9pbmZvGAIgAygLMhkucHJvdG8ubmV0LkNv" + "c3R1bWVVc2VJbmZvEhMKC2JhdHRsZV9tb2RlGAMgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[2]
	{
		new GeneratedClrTypeInfo(typeof(CostumeUseInfo), CostumeUseInfo.Parser, new string[2] { "CostumeIndex", "CharIndex" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(CostumeUseRequest), CostumeUseRequest.Parser, new string[3] { "Seq", "CostumeUseInfo", "BattleMode" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
