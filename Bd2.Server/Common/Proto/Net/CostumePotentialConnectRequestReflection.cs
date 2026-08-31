using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CostumePotentialConnectRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CixSZXF1ZXN0L0Nvc3R1bWVQb3RlbnRpYWxDb25uZWN0UmVxdWVzdC5wcm90" + "bxIJcHJvdG8ubmV0IkYKG0Nvc3R1bWVQb3RlbnRpYWxDb25uZWN0SW5mbxIT" + "CgtpbnZlbl9pbmRleBgBIAEoAxISCgpjb3N0dW1lX2lkGAIgASgFIn0KHkNv" + "c3R1bWVQb3RlbnRpYWxDb25uZWN0UmVxdWVzdBILCgNzZXEYASABKAUSTgoe" + "Y29zdHVtZV9wb3RlbnRpYWxfY29ubmVjdF9pbmZvGAIgAygLMiYucHJvdG8u" + "bmV0LkNvc3R1bWVQb3RlbnRpYWxDb25uZWN0SW5mb2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[2]
	{
		new GeneratedClrTypeInfo(typeof(CostumePotentialConnectInfo), CostumePotentialConnectInfo.Parser, new string[2] { "InvenIndex", "CostumeId" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(CostumePotentialConnectRequest), CostumePotentialConnectRequest.Parser, new string[2] { "Seq", "CostumePotentialConnectInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
