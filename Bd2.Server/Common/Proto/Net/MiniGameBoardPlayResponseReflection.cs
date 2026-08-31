using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameBoardPlayResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9NaW5pR2FtZUJvYXJkUGxheVJlc3BvbnNlLnByb3RvEglw" + "cm90by5uZXQaIUNvbW1vbnMvTWluaUdhbWVCb2FyZERCSW5mby5wcm90bxog" + "Q29tbW9ucy9SZXdhcmREQkluZm9CdW5kbGUucHJvdG8ikwIKGU1pbmlHYW1l" + "Qm9hcmRQbGF5UmVzcG9uc2USPAoUbWluaV9nYW1lX2JvYXJkX2luZm8YASAB" + "KAsyHi5wcm90by5uZXQuTWluaUdhbWVCb2FyZERCSW5mbxJIChltaW5pX2dh" + "bWVfY29udHJvbGxlcl9pbmZvGAIgAygLMiUucHJvdG8ubmV0Lk1pbmlHYW1l" + "TW92ZUNvbnRyb2xsZXJJbmZvEjYKD2NvbXBsZXRlX3Jld2FyZBgDIAEoCzId" + "LnByb3RvLm5ldC5SZXdhcmREQkluZm9CdW5kbGUSNgoPc2NhZmZvbGRfcmV3" + "YXJkGAQgASgLMh0ucHJvdG8ubmV0LlJld2FyZERCSW5mb0J1bmRsZWIGcHJv" + "dG8z"), new FileDescriptor[2]
	{
		MiniGameBoardDBInfoReflection.Descriptor,
		RewardDBInfoBundleReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameBoardPlayResponse), MiniGameBoardPlayResponse.Parser, new string[4] { "MiniGameBoardInfo", "MiniGameControllerInfo", "CompleteReward", "ScaffoldReward" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
