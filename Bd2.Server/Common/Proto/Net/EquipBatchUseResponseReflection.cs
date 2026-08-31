using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipBatchUseResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXNwb25zZS9FcXVpcEJhdGNoVXNlUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldBoYQ29tbW9ucy9DaGFyREJJbmZvLnByb3RvIkEKFUVxdWlwQmF0Y2hVc2VSZXNwb25zZRIoCgljaGFyX2luZm8YASADKAsyFS5wcm90by5uZXQuQ2hhckRCSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { CharDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipBatchUseResponse), EquipBatchUseResponse.Parser, new string[1] { "CharInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
