using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipClearResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXNwb25zZS9FcXVpcENsZWFyUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldBoYQ29tbW9ucy9DaGFyREJJbmZvLnByb3RvIj4KEkVxdWlwQ2xlYXJSZXNwb25zZRIoCgljaGFyX2luZm8YASABKAsyFS5wcm90by5uZXQuQ2hhckRCSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { CharDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipClearResponse), EquipClearResponse.Parser, new string[1] { "CharInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
