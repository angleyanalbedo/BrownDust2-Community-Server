using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class HuntDispatchInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXF1ZXN0L0h1bnREaXNwYXRjaEluZm9SZXF1ZXN0LnByb3RvEglwcm90by5uZXQiJgoXSHVudERpc3BhdGNoSW5mb1JlcXVlc3QSCwoDc2VxGAEgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(HuntDispatchInfoRequest), HuntDispatchInfoRequest.Parser, new string[1] { "Seq" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
