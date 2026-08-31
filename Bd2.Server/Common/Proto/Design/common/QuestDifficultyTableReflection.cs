using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class QuestDifficultyTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjtjb21tb24uZGIvUXVlc3RUYWJsZV9fX+2AmOyKpO2KuC9RdWVzdERpZmZp" + "Y3VsdHlUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiK2AgoUUXVl" + "c3REaWZmaWN1bHR5VGFibGUSDwoHZ3JvdXBJZBgBIAEoBRIKCgJpZBgCIAEo" + "BRIRCglsaW1pdFR5cGUYAyADKAUSHAoUbGltaXRUeXBlTG9jYWxUZXh0SWQY" + "BCADKAUSFgoObGltaXRUeXBlVmFsdWUYBSADKAUSGQoRbGltaXRpbW1vcnRh" + "bFR5cGUYBiADKAUSJAocbGltaXRpbW1vcnRhbFR5cGVMb2NhbFRleHRJZBgH" + "IAMoBRIeChZsaW1pdGltbW9ydGFsVHlwZVZhbHVlGAggAygFEhwKFHJlY29t" + "bWVuZEdyb3d0aFBvaW50GAkgASgFEhMKC3Jld2FyZENvdW50GAogAygFEhAK" + "CHJld2FyZElkGAsgAygFEhIKCnJld2FyZFR5cGUYDCADKAVCREITUHJvdG8u" + "RGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26qAhNQcm90" + "by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(QuestDifficultyTable), QuestDifficultyTable.Parser, new string[12]
		{
			"GroupId", "Id", "LimitType", "LimitTypeLocalTextId", "LimitTypeValue", "LimitimmortalType", "LimitimmortalTypeLocalTextId", "LimitimmortalTypeValue", "RecommendGrowthPoint", "RewardCount",
			"RewardId", "RewardType"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
