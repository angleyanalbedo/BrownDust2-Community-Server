using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class CostumeSelectTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjhjb21tb24uZGIvSXRlbVRhYmxlX19f7JWE7J207YWcL0Nvc3R1bWVTZWxl" + "Y3RUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiI+ChJDb3N0dW1l" + "U2VsZWN0VGFibGUSHAoUY29zdHVtZVJld2FyZEdyb3VwSWQYASABKAUSCgoC" + "aWQYAiABKAVCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRl" + "c2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CostumeSelectTable), CostumeSelectTable.Parser, new string[2] { "CostumeRewardGroupId", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
