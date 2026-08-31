using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class SolidarityLevelTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkNjb21tb24uZGIvQ2hhclRhYmxlX19fQ2hhcl9Db3N0dW1lX1NraWxsL1Nv" + "bGlkYXJpdHlMZXZlbFRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9u" + "In0KFFNvbGlkYXJpdHlMZXZlbFRhYmxlEgoKAmlkGAEgASgFEhMKC3Jld2Fy" + "ZENvdW50GAIgAygFEhAKCHJld2FyZElkGAMgAygFEhIKCnJld2FyZFR5cGUY" + "BCADKAUSHgoWc29saWRhcml0eUxldmVsUmVxdWlyZRgFIAEoBUJEQhNQcm90" + "by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1By" + "b3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(SolidarityLevelTable), SolidarityLevelTable.Parser, new string[5] { "Id", "RewardCount", "RewardId", "RewardType", "SolidarityLevelRequire" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
