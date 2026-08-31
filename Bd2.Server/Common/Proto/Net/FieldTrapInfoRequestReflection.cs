using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldTrapInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXF1ZXN0L0ZpZWxkVHJhcEluZm9SZXF1ZXN0LnByb3RvEglwcm90by5uZXQiRAoURmllbGRUcmFwSW5mb1JlcXVlc3QSCwoDc2VxGAEgASgFEg8KB3BhY2tfaWQYAiABKAUSDgoGbWFwX2lkGAMgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldTrapInfoRequest), FieldTrapInfoRequest.Parser, new string[3] { "Seq", "PackId", "MapId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
