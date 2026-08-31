using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EventExchangeInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9FdmVudEV4Y2hhbmdlSW5mb1Jlc3BvbnNlLnByb3RvEglw" + "cm90by5uZXQaIUNvbW1vbnMvRXZlbnRFeGNoYW5nZURCSW5mby5wcm90bxon" + "Q29tbW9ucy9FdmVudEV4Y2hhbmdlUmV3YXJkREJJbmZvLnByb3RvIqIBChlF" + "dmVudEV4Y2hhbmdlSW5mb1Jlc3BvbnNlEjsKE2V2ZW50X2V4Y2hhbmdlX2lu" + "Zm8YASADKAsyHi5wcm90by5uZXQuRXZlbnRFeGNoYW5nZURCSW5mbxJIChpl" + "dmVudF9leGNoYW5nZV9yZXdhcmRfaW5mbxgCIAMoCzIkLnByb3RvLm5ldC5F" + "dmVudEV4Y2hhbmdlUmV3YXJkREJJbmZvYgZwcm90bzM="), new FileDescriptor[2]
	{
		EventExchangeDBInfoReflection.Descriptor,
		EventExchangeRewardDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EventExchangeInfoResponse), EventExchangeInfoResponse.Parser, new string[2] { "EventExchangeInfo", "EventExchangeRewardInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
