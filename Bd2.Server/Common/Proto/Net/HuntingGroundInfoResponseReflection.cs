using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class HuntingGroundInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9IdW50aW5nR3JvdW5kSW5mb1Jlc3BvbnNlLnByb3RvEglw" + "cm90by5uZXQaIUNvbW1vbnMvSHVudGluZ0dyb3VuZERCSW5mby5wcm90byJY" + "ChlIdW50aW5nR3JvdW5kSW5mb1Jlc3BvbnNlEjsKE2h1bnRpbmdfZ3JvdW5k" + "X2luZm8YASABKAsyHi5wcm90by5uZXQuSHVudGluZ0dyb3VuZERCSW5mb2IG" + "cHJvdG8z"), new FileDescriptor[1] { HuntingGroundDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(HuntingGroundInfoResponse), HuntingGroundInfoResponse.Parser, new string[1] { "HuntingGroundInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
