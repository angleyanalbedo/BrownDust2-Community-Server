using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildMemberRoleEditResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXNwb25zZS9HdWlsZE1lbWJlclJvbGVFZGl0UmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldBofQ29tbW9ucy9HdWlsZE1lbWJlckRCSW5mby5wcm90byJQChtHdWlsZE1lbWJlclJvbGVFZGl0UmVzcG9uc2USMQoLbWVtYmVyX2luZm8YASADKAsyHC5wcm90by5uZXQuR3VpbGRNZW1iZXJEQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { GuildMemberDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildMemberRoleEditResponse), GuildMemberRoleEditResponse.Parser, new string[1] { "MemberInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
