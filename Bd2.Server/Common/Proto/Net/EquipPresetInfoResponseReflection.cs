using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipPresetInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXNwb25zZS9FcXVpcFByZXNldEluZm9SZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0GiFDb21tb25zL0VxdWlwUHJlc2V0Q2hhckluZm8ucHJvdG8iTAoXRXF1aXBQcmVzZXRJbmZvUmVzcG9uc2USMQoJY2hhcl9pbmZvGAEgAygLMh4ucHJvdG8ubmV0LkVxdWlwUHJlc2V0Q2hhckluZm9iBnByb3RvMw=="), new FileDescriptor[1] { EquipPresetCharInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipPresetInfoResponse), EquipPresetInfoResponse.Parser, new string[1] { "CharInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
