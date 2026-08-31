using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CharExpiryResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXNwb25zZS9DaGFyRXhwaXJ5UmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldBoYQ29tbW9ucy9EZWNrREJJbmZvLnByb3RvIj4KEkNoYXJFeHBpcnlSZXNwb25zZRIoCglkZWNrX2luZm8YASADKAsyFS5wcm90by5uZXQuRGVja0RCSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { DeckDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharExpiryResponse), CharExpiryResponse.Parser, new string[1] { "DeckInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
