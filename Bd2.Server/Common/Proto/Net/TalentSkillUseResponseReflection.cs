using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TalentSkillUseResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXNwb25zZS9UYWxlbnRTa2lsbFVzZVJlc3BvbnNlLnByb3RvEglwcm90" + "by5uZXQaGENvbW1vbnMvSXRlbURCSW5mby5wcm90bxoYQ29tbW9ucy9DaGFy" + "REJJbmZvLnByb3RvGhlDb21tb25zL0VxdWlwREJJbmZvLnByb3RvGhtDb21t" + "b25zL0Nvc3R1bWVEQkluZm8ucHJvdG8aH0NvbW1vbnMvVGFsZW50U2tpbGxE" + "QkluZm8ucHJvdG8aHUNvbW1vbnMvVGFsZW50TnBjREJJbmZvLnByb3RvGh5D" + "b21tb25zL1JlcHV0YXRpb25EQkluZm8ucHJvdG8aHENvbW1vbnMvRGlzcGF0" + "Y2hEQkluZm8ucHJvdG8aG0NvbW1vbnMvTW9uc3RlckRCSW5mby5wcm90byKB" + "BAoWVGFsZW50U2tpbGxVc2VSZXNwb25zZRI3ChF0YWxlbnRfc2tpbGxfaW5m" + "bxgBIAEoCzIcLnByb3RvLm5ldC5UYWxlbnRTa2lsbERCSW5mbxIzCg90YWxl" + "bnRfbnBjX2luZm8YAiABKAsyGi5wcm90by5uZXQuVGFsZW50TnBjREJJbmZv" + "EigKCWl0ZW1faW5mbxgDIAMoCzIVLnByb3RvLm5ldC5JdGVtREJJbmZvEioK" + "CmVxdWlwX2luZm8YBCADKAsyFi5wcm90by5uZXQuRXF1aXBEQkluZm8SLwoQ" + "cmV3YXJkX2NoYXJfaW5mbxgFIAMoCzIVLnByb3RvLm5ldC5DaGFyREJJbmZv" + "Ei4KDGNvc3R1bWVfaW5mbxgGIAMoCzIYLnByb3RvLm5ldC5Db3N0dW1lREJJ" + "bmZvEjQKD3JlcHV0YXRpb25faW5mbxgHIAMoCzIbLnByb3RvLm5ldC5SZXB1" + "dGF0aW9uREJJbmZvEjAKDWRpc3BhdGNoX2luZm8YCCADKAsyGS5wcm90by5u" + "ZXQuRGlzcGF0Y2hEQkluZm8SLgoMbW9uc3Rlcl9pbmZvGAkgAygLMhgucHJv" + "dG8ubmV0Lk1vbnN0ZXJEQkluZm8SFgoOYWRkX3RhbGVudF9leHAYCiABKAUS" + "EgoKaXNfc3VjY2VzcxgLIAEoCGIGcHJvdG8z"), new FileDescriptor[9]
	{
		ItemDBInfoReflection.Descriptor,
		CharDBInfoReflection.Descriptor,
		EquipDBInfoReflection.Descriptor,
		CostumeDBInfoReflection.Descriptor,
		TalentSkillDBInfoReflection.Descriptor,
		TalentNpcDBInfoReflection.Descriptor,
		ReputationDBInfoReflection.Descriptor,
		DispatchDBInfoReflection.Descriptor,
		MonsterDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TalentSkillUseResponse), TalentSkillUseResponse.Parser, new string[11]
		{
			"TalentSkillInfo", "TalentNpcInfo", "ItemInfo", "EquipInfo", "RewardCharInfo", "CostumeInfo", "ReputationInfo", "DispatchInfo", "MonsterInfo", "AddTalentExp",
			"IsSuccess"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
