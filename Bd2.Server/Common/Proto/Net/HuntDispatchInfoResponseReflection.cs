using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class HuntDispatchInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXNwb25zZS9IdW50RGlzcGF0Y2hJbmZvUmVzcG9uc2UucHJvdG8SCXBy" + "b3RvLm5ldBogQ29tbW9ucy9IdW50RGlzcGF0Y2hEQkluZm8ucHJvdG8ieQoY" + "SHVudERpc3BhdGNoSW5mb1Jlc3BvbnNlEjkKEmh1bnRfZGlzcGF0Y2hfaW5m" + "bxgBIAMoCzIdLnByb3RvLm5ldC5IdW50RGlzcGF0Y2hEQkluZm8SIgoaaHVu" + "dGluZ19ncm91bmRfbWluX3BhY2tfaWQYAiABKAViBnByb3RvMw=="), new FileDescriptor[1] { HuntDispatchDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(HuntDispatchInfoResponse), HuntDispatchInfoResponse.Parser, new string[2] { "HuntDispatchInfo", "HuntingGroundMinPackId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
