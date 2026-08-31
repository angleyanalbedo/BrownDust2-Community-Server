using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CharPartnerStoryRewardRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CitSZXF1ZXN0L0NoYXJQYXJ0bmVyU3RvcnlSZXdhcmRSZXF1ZXN0LnByb3RvEglwcm90by5uZXQiXQodQ2hhclBhcnRuZXJTdG9yeVJld2FyZFJlcXVlc3QSCwoDc2VxGAEgASgFEhMKC2ludmVuX2luZGV4GAIgASgDEhoKEnBhcnRuZXJfY2hhcl9pbmRleBgDIAEoA2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharPartnerStoryRewardRequest), CharPartnerStoryRewardRequest.Parser, new string[3] { "Seq", "InvenIndex", "PartnerCharIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
