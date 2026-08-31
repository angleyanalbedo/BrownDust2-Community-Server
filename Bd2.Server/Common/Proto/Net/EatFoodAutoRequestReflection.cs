using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EatFoodAutoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXF1ZXN0L0VhdEZvb2RBdXRvUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0" + "GhhDb21tb25zL0l0ZW1EQkluZm8ucHJvdG8isQEKEkVhdEZvb2RBdXRvUmVx" + "dWVzdBILCgNzZXEYASABKAUSQAoNZWF0X2Zvb2RfaW5mbxgCIAMoCzIpLnBy" + "b3RvLm5ldC5FYXRGb29kQXV0b1JlcXVlc3QuRm9vZFVzZUluZm8aTAoLRm9v" + "ZFVzZUluZm8SEwoLaW52ZW5faW5kZXgYASABKAMSKAoJaXRlbV9pbmZvGAIg" + "AygLMhUucHJvdG8ubmV0Lkl0ZW1EQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EatFoodAutoRequest), EatFoodAutoRequest.Parser, new string[2] { "Seq", "EatFoodInfo" }, null, null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EatFoodAutoRequest.Types.FoodUseInfo), EatFoodAutoRequest.Types.FoodUseInfo.Parser, new string[2] { "InvenIndex", "ItemInfo" }, null, null, null, null)
		})
	}));

	public static FileDescriptor Descriptor => descriptor;
}
