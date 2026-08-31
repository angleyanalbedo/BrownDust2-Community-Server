using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class CharGrowthTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj5jb21tb24uZGIvQ2hhclRhYmxlX19fQ2hhcl9Db3N0dW1lX1NraWxsL0No" + "YXJHcm93dGhUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiLdAQoP" + "Q2hhckdyb3d0aFRhYmxlEhgKEGNoYXJMZXZlbEdyb3VwSWQYASABKAUSGAoQ" + "Y2xhc3N1cEl0ZW1Db3VudBgCIAMoBRIVCg1jbGFzc3VwSXRlbUlkGAMgAygF" + "EhcKD2NsYXNzdXBJdGVtVHlwZRgEIAMoBRIYChBkaXNtaXNzSXRlbUNvdW50" + "GAUgAygFEhUKDWRpc21pc3NJdGVtSWQYBiADKAUSFwoPZGlzbWlzc0l0ZW1U" + "eXBlGAcgAygFEgoKAmlkGAggASgFEhAKCG1heExldmVsGAkgASgFQkRCE1By" + "b3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgIT" + "UHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharGrowthTable), CharGrowthTable.Parser, new string[9] { "CharLevelGroupId", "ClassupItemCount", "ClassupItemId", "ClassupItemType", "DismissItemCount", "DismissItemId", "DismissItemType", "Id", "MaxLevel" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
