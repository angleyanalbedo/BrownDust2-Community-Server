using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class GrowUpGuideTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjhjb21tb24uZGIvVHV0b3JpYWxfX1/tipzthqDrpqzslrwvR3Jvd1VwR3Vp" + "ZGVUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiKIAQoQR3Jvd1Vw" + "R3VpZGVUYWJsZRIQCghjYXRlZ29yeRgBIAEoBRISCgpjYXRlZ29yeUlkGAIg" + "ASgFEhAKCGRlc2NUZXh0GAMgASgFEg8KB2dyb3VwSWQYBCABKAUSFwoPZ3Vp" + "ZGVUdXRvcmlhbElkGAUgAygFEhIKCnNob3J0Q3V0SWQYBiABKAVCREITUHJv" + "dG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26qAhNQ" + "cm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GrowUpGuideTable), GrowUpGuideTable.Parser, new string[6] { "Category", "CategoryId", "DescText", "GroupId", "GuideTutorialId", "ShortCutId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
