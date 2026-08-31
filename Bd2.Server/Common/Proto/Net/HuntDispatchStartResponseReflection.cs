using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class HuntDispatchStartResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9IdW50RGlzcGF0Y2hTdGFydFJlc3BvbnNlLnByb3RvEglw" + "cm90by5uZXQaIENvbW1vbnMvSHVudERpc3BhdGNoREJJbmZvLnByb3RvIlYK" + "GUh1bnREaXNwYXRjaFN0YXJ0UmVzcG9uc2USOQoSaHVudF9kaXNwYXRjaF9p" + "bmZvGAEgASgLMh0ucHJvdG8ubmV0Lkh1bnREaXNwYXRjaERCSW5mb2IGcHJv" + "dG8z"), new FileDescriptor[1] { HuntDispatchDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(HuntDispatchStartResponse), HuntDispatchStartResponse.Parser, new string[1] { "HuntDispatchInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
