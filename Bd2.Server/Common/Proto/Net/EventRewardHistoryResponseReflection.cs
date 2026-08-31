using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EventRewardHistoryResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilSZXNwb25zZS9FdmVudFJld2FyZEhpc3RvcnlSZXNwb25zZS5wcm90bxIJ" + "cHJvdG8ubmV0GiZDb21tb25zL0V2ZW50UmV3YXJkSGlzdG9yeURCSW5mby5w" + "cm90byJXChpFdmVudFJld2FyZEhpc3RvcnlSZXNwb25zZRI5CgxoaXN0b3J5" + "X2luZm8YASADKAsyIy5wcm90by5uZXQuRXZlbnRSZXdhcmRIaXN0b3J5REJJ" + "bmZvYgZwcm90bzM="), new FileDescriptor[1] { EventRewardHistoryDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EventRewardHistoryResponse), EventRewardHistoryResponse.Parser, new string[1] { "HistoryInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
