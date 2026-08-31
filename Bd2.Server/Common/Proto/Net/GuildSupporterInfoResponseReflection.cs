using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildSupporterInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilSZXNwb25zZS9HdWlsZFN1cHBvcnRlckluZm9SZXNwb25zZS5wcm90bxIJ" + "cHJvdG8ubmV0GiBDb21tb25zL0d1aWxkU3VwcG9ydGVySW5mby5wcm90byJT" + "ChpHdWlsZFN1cHBvcnRlckluZm9SZXNwb25zZRI1Cg5zdXBwb3J0ZXJfaW5m" + "bxgBIAEoCzIdLnByb3RvLm5ldC5HdWlsZFN1cHBvcnRlckluZm9iBnByb3Rv" + "Mw=="), new FileDescriptor[1] { GuildSupporterInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildSupporterInfoResponse), GuildSupporterInfoResponse.Parser, new string[1] { "SupporterInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
