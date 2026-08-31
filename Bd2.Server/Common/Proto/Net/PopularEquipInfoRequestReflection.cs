using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PopularEquipInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXF1ZXN0L1BvcHVsYXJFcXVpcEluZm9SZXF1ZXN0LnByb3RvEglwcm90by5uZXQiPgoXUG9wdWxhckVxdWlwSW5mb1JlcXVlc3QSCwoDc2VxGAEgASgFEhYKDnVuaXF1ZV9jaGFyX2lkGAIgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PopularEquipInfoRequest), PopularEquipInfoRequest.Parser, new string[2] { "Seq", "UniqueCharId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
