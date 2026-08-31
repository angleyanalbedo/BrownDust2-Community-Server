using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class RLBuffTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjVjb21tb24uZGIvUm9ndWVsaWtlX+uhnOq3uOudvOydtO2BrC9STEJ1ZmZU" + "YWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiK9AQoLUkxCdWZmVGFi" + "bGUSFwoPY29uZGl0aW9uVGltaW5nGAEgASgFEhUKDWNvbmRpdGlvblR5cGUY" + "AiABKAUSFgoOY29uZGl0aW9uVmFsdWUYAyABKAUSFwoPZWZmZWN0QXBwbHlU" + "eXBlGAQgASgFEhgKEGVmZmVjdEFwcGx5VmFsdWUYBSADKAUSEgoKZWZmZWN0" + "VHlwZRgGIAEoBRITCgtlZmZlY3RWYWx1ZRgHIAEoARIKCgJpZBgIIAEoBUJE" + "QhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1v" + "bqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(RLBuffTable), RLBuffTable.Parser, new string[8] { "ConditionTiming", "ConditionType", "ConditionValue", "EffectApplyType", "EffectApplyValue", "EffectType", "EffectValue", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
