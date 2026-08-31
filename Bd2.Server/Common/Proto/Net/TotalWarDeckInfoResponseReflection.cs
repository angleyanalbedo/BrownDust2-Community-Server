using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TotalWarDeckInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXNwb25zZS9Ub3RhbFdhckRlY2tJbmZvUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldBogQ29tbW9ucy9Ub3RhbFdhckRlY2tEQkluZm8ucHJvdG8iTAoYVG90YWxXYXJEZWNrSW5mb1Jlc3BvbnNlEjAKCWRlY2tfaW5mbxgBIAMoCzIdLnByb3RvLm5ldC5Ub3RhbFdhckRlY2tEQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { TotalWarDeckDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TotalWarDeckInfoResponse), TotalWarDeckInfoResponse.Parser, new string[1] { "DeckInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
