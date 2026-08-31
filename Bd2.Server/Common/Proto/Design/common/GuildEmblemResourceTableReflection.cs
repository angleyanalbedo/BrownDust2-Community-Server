using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class GuildEmblemResourceTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjZjb21tb24uZGIvR3VpbGRfX+q4uOuTnC9HdWlsZEVtYmxlbVJlc291cmNl" + "VGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iWQoYR3VpbGRFbWJs" + "ZW1SZXNvdXJjZVRhYmxlEhsKE2Rpc3BsYXlSZXNvdXJjZU5hbWUYASABKAkS" + "CgoCaWQYAiABKAUSFAoMcmVzb3VyY2VOYW1lGAMgASgJQkRCE1Byb3RvLkRl" + "c2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8u" + "RGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildEmblemResourceTable), GuildEmblemResourceTable.Parser, new string[3] { "DisplayResourceName", "Id", "ResourceName" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
