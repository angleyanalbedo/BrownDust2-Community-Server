using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class FocusTutorialTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjpjb21tb24uZGIvVHV0b3JpYWxfX1/tipzthqDrpqzslrwvRm9jdXNUdXRv" + "cmlhbFRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIj8KEkZvY3Vz" + "VHV0b3JpYWxUYWJsZRIPCgdldmVudElkGAEgASgJEgoKAmlkGAIgASgFEgwK" + "BHR5cGUYAyABKAVCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3Rv" + "LkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FocusTutorialTable), FocusTutorialTable.Parser, new string[3] { "EventId", "Id", "Type" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
