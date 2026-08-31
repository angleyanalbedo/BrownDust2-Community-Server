using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class OverwhelmResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXNwb25zZS9PdmVyd2hlbG1SZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0" + "GiBDb21tb25zL1Jld2FyZERCSW5mb0J1bmRsZS5wcm90bxobQ29tbW9ucy9N" + "b25zdGVyREJJbmZvLnByb3RvIpIBChFPdmVyd2hlbG1SZXNwb25zZRIuCgxt" + "b25zdGVyX2luZm8YASADKAsyGC5wcm90by5uZXQuTW9uc3RlckRCSW5mbxIX" + "Cg91cGRhdGVfcXVlc3RfaWQYAiADKAUSNAoNcmV3YXJkX2J1bmRsZRgDIAEo" + "CzIdLnByb3RvLm5ldC5SZXdhcmREQkluZm9CdW5kbGViBnByb3RvMw=="), new FileDescriptor[2]
	{
		RewardDBInfoBundleReflection.Descriptor,
		MonsterDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(OverwhelmResponse), OverwhelmResponse.Parser, new string[3] { "MonsterInfo", "UpdateQuestId", "RewardBundle" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
