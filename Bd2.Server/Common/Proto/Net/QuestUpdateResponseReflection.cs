using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class QuestUpdateResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXNwb25zZS9RdWVzdFVwZGF0ZVJlc3BvbnNlLnByb3RvEglwcm90by5u" + "ZXQaIENvbW1vbnMvUmV3YXJkREJJbmZvQnVuZGxlLnByb3RvImkKE1F1ZXN0" + "VXBkYXRlUmVzcG9uc2USFwoPdXBkYXRlX3F1ZXN0X2lkGAEgASgFEjkKEnJl" + "d2FyZF9pbmZvX2J1bmRsZRgCIAEoCzIdLnByb3RvLm5ldC5SZXdhcmREQklu" + "Zm9CdW5kbGViBnByb3RvMw=="), new FileDescriptor[1] { RewardDBInfoBundleReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(QuestUpdateResponse), QuestUpdateResponse.Parser, new string[2] { "UpdateQuestId", "RewardInfoBundle" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
