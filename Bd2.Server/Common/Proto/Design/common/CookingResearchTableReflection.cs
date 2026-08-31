using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class CookingResearchTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjpjb21tb24uZGIvSXRlbVRhYmxlX19f7JWE7J207YWcL0Nvb2tpbmdSZXNl" + "YXJjaFRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIlcKFENvb2tp" + "bmdSZXNlYXJjaFRhYmxlEhUKDWNhdGFseXN0VmFsdWUYASADKAUSEgoKZmFp" + "bEl0ZW1JZBgCIAEoBRIUCgx1c2VTbG90Q291bnQYAyADKAVCREITUHJvdG8u" + "RGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26qAhNQcm90" + "by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CookingResearchTable), CookingResearchTable.Parser, new string[3] { "CatalystValue", "FailItemId", "UseSlotCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
