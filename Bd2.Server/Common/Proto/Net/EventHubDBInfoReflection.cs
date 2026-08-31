using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EventHubDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxDb21tb25zL0V2ZW50SHViREJJbmZvLnByb3RvEglwcm90by5uZXQaI0Nv" + "bW1vbnMvRXZlbnRIdWJTZXR0aW5nREJJbmZvLnByb3RvIqIBCg5FdmVudEh1" + "YkRCSW5mbxILCgN1aWQYASABKAUSDgoGaHViX2lkGAIgASgFEhIKCnN0YXJ0" + "X3RpbWUYAyABKAMSFQoNcGxheV9lbmRfdGltZRgEIAEoAxIQCghlbmRfdGlt" + "ZRgFIAEoAxI2CgxzZXR0aW5nX2luZm8YBiADKAsyIC5wcm90by5uZXQuRXZl" + "bnRIdWJTZXR0aW5nREJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { EventHubSettingDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EventHubDBInfo), EventHubDBInfo.Parser, new string[6] { "Uid", "HubId", "StartTime", "PlayEndTime", "EndTime", "SettingInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
