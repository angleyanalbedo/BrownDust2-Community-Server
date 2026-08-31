using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PictorialBookInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9QaWN0b3JpYWxCb29rSW5mb1Jlc3BvbnNlLnByb3RvEglw" + "cm90by5uZXQaIUNvbW1vbnMvUGljdG9yaWFsQm9va0RCSW5mby5wcm90byJX" + "ChlQaWN0b3JpYWxCb29rSW5mb1Jlc3BvbnNlEjoKEnBpY3RvcmlhbGJvb2tf" + "aW5mbxgBIAMoCzIeLnByb3RvLm5ldC5QaWN0b3JpYWxCb29rREJJbmZvYgZw" + "cm90bzM="), new FileDescriptor[1] { PictorialBookDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PictorialBookInfoResponse), PictorialBookInfoResponse.Parser, new string[1] { "PictorialbookInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
