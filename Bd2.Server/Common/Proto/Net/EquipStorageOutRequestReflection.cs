using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipStorageOutRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXF1ZXN0L0VxdWlwU3RvcmFnZU91dFJlcXVlc3QucHJvdG8SCXByb3RvLm5ldBoZQ29tbW9ucy9FcXVpcERCSW5mby5wcm90byJRChZFcXVpcFN0b3JhZ2VPdXRSZXF1ZXN0EgsKA3NlcRgBIAEoBRIqCgplcXVpcF9pbmZvGAIgASgLMhYucHJvdG8ubmV0LkVxdWlwREJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { EquipDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipStorageOutRequest), EquipStorageOutRequest.Parser, new string[2] { "Seq", "EquipInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
