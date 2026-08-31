using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildJoinResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXNwb25zZS9HdWlsZEpvaW5SZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0" + "GhRDb21tb25zL0RlZmluZS5wcm90bxoZQ29tbW9ucy9HdWlsZERCSW5mby5w" + "cm90bxofQ29tbW9ucy9HdWlsZE1lbWJlckRCSW5mby5wcm90byLQAQoRR3Vp" + "bGRKb2luUmVzcG9uc2USKgoKZ3VpbGRfaW5mbxgBIAEoCzIWLnByb3RvLm5l" + "dC5HdWlsZERCSW5mbxIxCgttZW1iZXJfaW5mbxgCIAMoCzIcLnByb3RvLm5l" + "dC5HdWlsZE1lbWJlckRCSW5mbxIQCghiYW5fdGltZRgDIAEoAxI1CgtyZXN1" + "bHRfdHlwZRgEIAEoDjIgLnByb3RvLm5ldC5EZWZpbmVfSm9pblJlc3VsdFR5" + "cGUSEwoLdG9wX3BlcmNlbnQYBSABKAFiBnByb3RvMw=="), new FileDescriptor[3]
	{
		DefineReflection.Descriptor,
		GuildDBInfoReflection.Descriptor,
		GuildMemberDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildJoinResponse), GuildJoinResponse.Parser, new string[5] { "GuildInfo", "MemberInfo", "BanTime", "ResultType", "TopPercent" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
