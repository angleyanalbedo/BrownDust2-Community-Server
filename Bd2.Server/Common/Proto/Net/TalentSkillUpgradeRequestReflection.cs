using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TalentSkillUpgradeRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXF1ZXN0L1RhbGVudFNraWxsVXBncmFkZVJlcXVlc3QucHJvdG8SCXBy" + "b3RvLm5ldBoYQ29tbW9ucy9JdGVtREJJbmZvLnByb3RvImcKGVRhbGVudFNr" + "aWxsVXBncmFkZVJlcXVlc3QSCwoDc2VxGAEgASgFEhMKC2ludmVuX2luZGV4" + "GAIgASgDEigKCWl0ZW1faW5mbxgDIAMoCzIVLnByb3RvLm5ldC5JdGVtREJJ" + "bmZvYgZwcm90bzM="), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TalentSkillUpgradeRequest), TalentSkillUpgradeRequest.Parser, new string[3] { "Seq", "InvenIndex", "ItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
