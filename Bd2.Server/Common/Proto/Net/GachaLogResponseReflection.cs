using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GachaLogResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXNwb25zZS9HYWNoYUxvZ1Jlc3BvbnNlLnByb3RvEglwcm90by5uZXQa" + "HENvbW1vbnMvR2FjaGFMb2dEQkluZm8ucHJvdG8igAEKEEdhY2hhTG9nUmVz" + "cG9uc2USLAoJZ2FjaGFfbG9nGAEgAygLMhkucHJvdG8ubmV0LkdhY2hhTG9n" + "REJJbmZvEj4KFmdhY2hhX3RvdGFsX2NvdW50X2luZm8YAiADKAsyHi5wcm90" + "by5uZXQuR2FjaGFUb3RhbENvdW50SW5mb2IGcHJvdG8z"), new FileDescriptor[1] { GachaLogDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GachaLogResponse), GachaLogResponse.Parser, new string[2] { "GachaLog", "GachaTotalCountInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
