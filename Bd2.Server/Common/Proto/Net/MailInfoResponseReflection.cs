using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MailInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXNwb25zZS9NYWlsSW5mb1Jlc3BvbnNlLnByb3RvEglwcm90by5uZXQa" + "GENvbW1vbnMvTWFpbERCSW5mby5wcm90byJqChBNYWlsSW5mb1Jlc3BvbnNl" + "EigKCW1haWxfaW5mbxgBIAMoCzIVLnByb3RvLm5ldC5NYWlsREJJbmZvEhMK" + "C3RvdGFsX2NvdW50GAIgASgFEhcKD21heF9pbnZlbl9pbmRleBgDIAEoA2IG" + "cHJvdG8z"), new FileDescriptor[1] { MailDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MailInfoResponse), MailInfoResponse.Parser, new string[3] { "MailInfo", "TotalCount", "MaxInvenIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
