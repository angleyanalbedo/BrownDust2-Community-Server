using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class CostumeGrowthTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkFjb21tb24uZGIvQ2hhclRhYmxlX19fQ2hhcl9Db3N0dW1lX1NraWxsL0Nv" + "c3R1bWVHcm93dGhUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiKz" + "AgoSQ29zdHVtZUdyb3d0aFRhYmxlEhwKFGdldEV4Y2hhbmdlSXRlbUNvdW50" + "GAEgASgFEhkKEWdldEV4Y2hhbmdlSXRlbUlkGAIgASgFEhsKE2dldEV4Y2hh" + "bmdlSXRlbVR5cGUYAyABKAUSDwoHZ3JvdXBJZBgEIAEoBRIXCg9ncm93dGhJ" + "dGVtQ291bnQYBSADKAUSFAoMZ3Jvd3RoSXRlbUlkGAYgAygFEhYKDmdyb3d0" + "aEl0ZW1UeXBlGAcgAygFEgoKAmlkGAggASgFEhgKEG1pbGVhZ2VJdGVtQ291" + "bnQYCSABKAUSFQoNbWlsZWFnZUl0ZW1JZBgKIAEoBRIXCg9taWxlYWdlSXRl" + "bVR5cGUYCyABKAUSGQoRb3ZlckV4Y2hhbmdlQ291bnQYDCABKAVCREITUHJv" + "dG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26qAhNQ" + "cm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CostumeGrowthTable), CostumeGrowthTable.Parser, new string[12]
		{
			"GetExchangeItemCount", "GetExchangeItemId", "GetExchangeItemType", "GroupId", "GrowthItemCount", "GrowthItemId", "GrowthItemType", "Id", "MileageItemCount", "MileageItemId",
			"MileageItemType", "OverExchangeCount"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
