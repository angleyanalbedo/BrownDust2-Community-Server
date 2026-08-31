using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipsClearRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXF1ZXN0L0VxdWlwc0NsZWFyUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0" + "IkUKDkVxdWlwQ2xlYXJJbmZvEhgKEGNoYXJfaW52ZW5faW5kZXgYASABKAMS" + "GQoRZXF1aXBfaW52ZW5faW5kZXgYAiADKAMiUAoSRXF1aXBzQ2xlYXJSZXF1" + "ZXN0EgsKA3NlcRgBIAEoBRItCgpjbGVhcl9pbmZvGAIgAygLMhkucHJvdG8u" + "bmV0LkVxdWlwQ2xlYXJJbmZvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[2]
	{
		new GeneratedClrTypeInfo(typeof(EquipClearInfo), EquipClearInfo.Parser, new string[2] { "CharInvenIndex", "EquipInvenIndex" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(EquipsClearRequest), EquipsClearRequest.Parser, new string[2] { "Seq", "ClearInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
