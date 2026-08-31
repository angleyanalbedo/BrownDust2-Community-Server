using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildMemberDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Db21tb25zL0d1aWxkTWVtYmVyREJJbmZvLnByb3RvEglwcm90by5uZXQa" + "FENvbW1vbnMvRGVmaW5lLnByb3RvGh9Db21tb25zL0Nvc3R1bWVCYXNlREJJ" + "bmZvLnByb3RvIqYCChFHdWlsZE1lbWJlckRCSW5mbxIKCgJpZBgBIAEoAxIT" + "Cgtvd25lcl9pbmRleBgCIAEoAxIPCgd1c2VyX2lkGAMgASgJEhAKCHRpdGxl" + "X2lkGAQgASgFEhsKE3BvcnRyYWl0X2Nvc3R1bWVfaWQYBSABKAUSLwoEcm9s" + "ZRgGIAEoDjIhLnByb3RvLm5ldC5EZWZpbmVfR3VpbGRNZW1iZXJSb2xlEg0K" + "BXBvaW50GAcgASgFEjQKDnN1cHBvcnRlcl9pbmZvGAggAygLMhwucHJvdG8u" + "bmV0LkNvc3R1bWVCYXNlREJJbmZvEhcKD2xhc3RfbG9naW5fZGF0ZRgJIAEo" + "AxITCgt1cGRhdGVfZGF0ZRgKIAEoAxIMCgRkYXRlGAsgASgDYgZwcm90bzM="), new FileDescriptor[2]
	{
		DefineReflection.Descriptor,
		CostumeBaseDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildMemberDBInfo), GuildMemberDBInfo.Parser, new string[11]
		{
			"Id", "OwnerIndex", "UserId", "TitleId", "PortraitCostumeId", "Role", "Point", "SupporterInfo", "LastLoginDate", "UpdateDate",
			"Date"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
