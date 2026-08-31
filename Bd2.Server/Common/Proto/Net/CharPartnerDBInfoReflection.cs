using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CharPartnerDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Db21tb25zL0NoYXJQYXJ0bmVyREJJbmZvLnByb3RvEglwcm90by5uZXQiYQoRQ2hhclBhcnRuZXJEQkluZm8SFgoObWFpbl91bmlxdWVfaWQYASABKAUSFQoNc3ViX3VuaXF1ZV9pZBgCIAEoBRINCgVwb2ludBgDIAEoBRIOCgZyZXdhcmQYBCABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharPartnerDBInfo), CharPartnerDBInfo.Parser, new string[4] { "MainUniqueId", "SubUniqueId", "Point", "Reward" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
