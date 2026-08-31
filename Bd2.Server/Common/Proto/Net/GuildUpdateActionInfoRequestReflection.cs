using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildUpdateActionInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXF1ZXN0L0d1aWxkVXBkYXRlQWN0aW9uSW5mb1JlcXVlc3QucHJvdG8SCXByb3RvLm5ldBoUQ29tbW9ucy9EZWZpbmUucHJvdG8iWAocR3VpbGRVcGRhdGVBY3Rpb25JbmZvUmVxdWVzdBILCgNzZXEYASABKAUSKwoEdHlwZRgCIAMoDjIdLnByb3RvLm5ldC5EZWZpbmVfR3VpbGRBY3Rpb25iBnByb3RvMw=="), new FileDescriptor[1] { DefineReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildUpdateActionInfoRequest), GuildUpdateActionInfoRequest.Parser, new string[2] { "Seq", "Type" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
