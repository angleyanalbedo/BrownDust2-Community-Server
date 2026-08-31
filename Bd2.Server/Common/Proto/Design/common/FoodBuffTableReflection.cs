using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class FoodBuffTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjNjb21tb24uZGIvSXRlbVRhYmxlX19f7JWE7J207YWcL0Zvb2RCdWZmVGFi" + "bGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iOAoNRm9vZEJ1ZmZUYWJs" + "ZRIKCgJpZBgBIAEoBRIMCgR0eXBlGAIgASgFEg0KBXZhbHVlGAMgASgFQkRC" + "E1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9u" + "qgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FoodBuffTable), FoodBuffTable.Parser, new string[3] { "Id", "Type", "Value" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
