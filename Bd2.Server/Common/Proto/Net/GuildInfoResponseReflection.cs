using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXNwb25zZS9HdWlsZEluZm9SZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0" + "GhxDb21tb25zL1VzZXJCYXNlREJJbmZvLnByb3RvGhlDb21tb25zL0d1aWxk" + "REJJbmZvLnByb3RvGh9Db21tb25zL0d1aWxkTWVtYmVyREJJbmZvLnByb3Rv" + "Gh9Db21tb25zL0d1aWxkQWN0aW9uREJJbmZvLnByb3RvGiFDb21tb25zL0d1" + "aWxkUmFpZFBsYXlEQkluZm8ucHJvdG8iuQIKEUd1aWxkSW5mb1Jlc3BvbnNl" + "EioKCmd1aWxkX2luZm8YASABKAsyFi5wcm90by5uZXQuR3VpbGREQkluZm8S" + "MQoLbWVtYmVyX2luZm8YAiADKAsyHC5wcm90by5uZXQuR3VpbGRNZW1iZXJE" + "QkluZm8SMQoOam9pbl9yZWN2X2luZm8YAyADKAsyGS5wcm90by5uZXQuVXNl" + "ckJhc2VEQkluZm8SMQoLYWN0aW9uX2luZm8YBCADKAsyHC5wcm90by5uZXQu" + "R3VpbGRBY3Rpb25EQkluZm8SFQoNaXNfYXR0ZW5kYW5jZRgFIAEoCBI2Cg5y" + "YWlkX3BsYXlfaW5mbxgGIAEoCzIeLnByb3RvLm5ldC5HdWlsZFJhaWRQbGF5" + "REJJbmZvEhAKCGJhbl90aW1lGAcgASgDYgZwcm90bzM="), new FileDescriptor[5]
	{
		UserBaseDBInfoReflection.Descriptor,
		GuildDBInfoReflection.Descriptor,
		GuildMemberDBInfoReflection.Descriptor,
		GuildActionDBInfoReflection.Descriptor,
		GuildRaidPlayDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildInfoResponse), GuildInfoResponse.Parser, new string[7] { "GuildInfo", "MemberInfo", "JoinRecvInfo", "ActionInfo", "IsAttendance", "RaidPlayInfo", "BanTime" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
