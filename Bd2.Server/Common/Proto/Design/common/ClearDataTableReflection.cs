using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class ClearDataTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkFjb21tb24uZGIvQ3JlYXJEYXRhX19f7IKt7KCc642w7J207YSwIOq0gOum" + "rC9DbGVhckRhdGFUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiJc" + "Cg5DbGVhckRhdGFUYWJsZRIXCg9kZWxldGVDb3N0dW1lSUQYASADKAUSFAoM" + "ZGVsZXRlUGFja0lEGAIgAygFEgoKAmlkGAMgASgFEg8KB3ZlcnNpb24YBCAB" + "KAlCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5j" + "b21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ClearDataTable), ClearDataTable.Parser, new string[4] { "DeleteCostumeID", "DeletePackID", "Id", "Version" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
