using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class UpdateIntroduceTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjpjb21tb24uZGIvRXZlbnRUYWJsZV9f7J2067Kk7Yq4L1VwZGF0ZUludHJv" + "ZHVjZVRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIpcBChRVcGRh" + "dGVJbnRyb2R1Y2VUYWJsZRIZChFjb3N0dW1lSWxsdXN0UGF0aBgBIAEoCRIK" + "CgJpZBgCIAEoBRIPCgdtYWdpY0lkGAMgASgFEg8KB29yZGVySWQYBCABKAUS" + "FAoMcmVzb3VyY2VQYXRoGAUgASgJEhIKCnN1Yk1hZ2ljSWQYBiABKAUSDAoE" + "dHlwZRgHIAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8u" + "RGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(UpdateIntroduceTable), UpdateIntroduceTable.Parser, new string[7] { "CostumeIllustPath", "Id", "MagicId", "OrderId", "ResourcePath", "SubMagicId", "Type" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
