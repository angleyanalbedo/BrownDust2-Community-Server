using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PackClearRewardRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXF1ZXN0L1BhY2tDbGVhclJld2FyZFJlcXVlc3QucHJvdG8SCXByb3Rv" + "Lm5ldBojQ29tbW9ucy9QYWNrQ2xlYXJSZXdhcmREQkluZm8ucHJvdG8iWwoW" + "UGFja0NsZWFyUmV3YXJkUmVxdWVzdBILCgNzZXEYASABKAUSNAoKY2xlYXJf" + "aW5mbxgCIAEoCzIgLnByb3RvLm5ldC5QYWNrQ2xlYXJSZXdhcmREQkluZm9i" + "BnByb3RvMw=="), new FileDescriptor[1] { PackClearRewardDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackClearRewardRequest), PackClearRewardRequest.Parser, new string[2] { "Seq", "ClearInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
