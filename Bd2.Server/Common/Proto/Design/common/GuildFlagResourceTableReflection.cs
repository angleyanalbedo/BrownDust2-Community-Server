using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class GuildFlagResourceTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjRjb21tb24uZGIvR3VpbGRfX+q4uOuTnC9HdWlsZEZsYWdSZXNvdXJjZVRh" + "YmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uImYKFkd1aWxkRmxhZ1Jl" + "c291cmNlVGFibGUSDwoHZ3JvdXBJZBgBIAEoBRIKCgJpZBgCIAEoBRIZChFp" + "c0Rpc3BsYXlSZXNvdXJjZRgDIAEoBRIUCgxyZXNvdXJjZU5hbWUYBCABKAlC" + "REITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21t" + "b26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildFlagResourceTable), GuildFlagResourceTable.Parser, new string[4] { "GroupId", "Id", "IsDisplayResource", "ResourceName" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
