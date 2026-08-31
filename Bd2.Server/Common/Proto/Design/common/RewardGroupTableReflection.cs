using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class RewardGroupTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjZjb21tb24uZGIvSXRlbVRhYmxlX19f7JWE7J207YWcL1Jld2FyZEdyb3Vw" + "VGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24ilwEKEFJld2FyZEdy" + "b3VwVGFibGUSEQoJZHJvcENvdW50GAEgASgFEhAKCGRyb3BUeXBlGAIgASgF" + "EgoKAmlkGAMgASgFEhEKCWl0ZW1Db3VudBgEIAMoBRIOCgZpdGVtSWQYBSAD" + "KAUSEAoIaXRlbVR5cGUYBiADKAUSDgoGbWFpbElkGAcgASgFEg0KBXJhdGlv" + "GAggAygFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNp" + "Z24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(RewardGroupTable), RewardGroupTable.Parser, new string[8] { "DropCount", "DropType", "Id", "ItemCount", "ItemId", "ItemType", "MailId", "Ratio" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
