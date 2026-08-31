using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipMakingResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXNwb25zZS9FcXVpcE1ha2luZ1Jlc3BvbnNlLnByb3RvEglwcm90by5uZXQaGUNvbW1vbnMvRXF1aXBEQkluZm8ucHJvdG8iWQoTRXF1aXBNYWtpbmdSZXNwb25zZRIqCgplcXVpcF9pbmZvGAEgAygLMhYucHJvdG8ubmV0LkVxdWlwREJJbmZvEhYKDmFkZF90YWxlbnRfZXhwGAIgASgFYgZwcm90bzM="), new FileDescriptor[1] { EquipDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipMakingResponse), EquipMakingResponse.Parser, new string[2] { "EquipInfo", "AddTalentExp" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
