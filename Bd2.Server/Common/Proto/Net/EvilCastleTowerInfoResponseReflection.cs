using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleTowerInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXNwb25zZS9FdmlsQ2FzdGxlVG93ZXJJbmZvUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldBojQ29tbW9ucy9FdmlsQ2FzdGxlVG93ZXJEQkluZm8ucHJvdG8iTQobRXZpbENhc3RsZVRvd2VySW5mb1Jlc3BvbnNlEi4KBGluZm8YASADKAsyIC5wcm90by5uZXQuRXZpbENhc3RsZVRvd2VyREJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { EvilCastleTowerDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleTowerInfoResponse), EvilCastleTowerInfoResponse.Parser, new string[1] { "Info" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
