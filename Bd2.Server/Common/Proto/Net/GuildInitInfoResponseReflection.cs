using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildInitInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXNwb25zZS9HdWlsZEluaXRJbmZvUmVzcG9uc2UucHJvdG8SCXByb3Rv" + "Lm5ldBocQ29tbW9ucy9Vc2VyQmFzZURCSW5mby5wcm90bxofQ29tbW9ucy9H" + "dWlsZEFjdGlvbkRCSW5mby5wcm90bxohQ29tbW9ucy9HdWlsZFJhaWRQbGF5" + "REJJbmZvLnByb3RvIsgBChVHdWlsZEluaXRJbmZvUmVzcG9uc2USMQoOam9p" + "bl9yZWN2X2luZm8YASADKAsyGS5wcm90by5uZXQuVXNlckJhc2VEQkluZm8S" + "MQoLYWN0aW9uX2luZm8YAiADKAsyHC5wcm90by5uZXQuR3VpbGRBY3Rpb25E" + "QkluZm8SEQoJaXNfcmV3YXJkGAMgASgIEjYKDnJhaWRfcGxheV9pbmZvGAQg" + "ASgLMh4ucHJvdG8ubmV0Lkd1aWxkUmFpZFBsYXlEQkluZm9iBnByb3RvMw=="), new FileDescriptor[3]
	{
		UserBaseDBInfoReflection.Descriptor,
		GuildActionDBInfoReflection.Descriptor,
		GuildRaidPlayDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildInitInfoResponse), GuildInitInfoResponse.Parser, new string[4] { "JoinRecvInfo", "ActionInfo", "IsReward", "RaidPlayInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
