using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class MonsterHuntSkillConditionTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ClFjb21tb24uZGIvTW9uc3Rlckh1bnRUYWJsZV9fX+uqrOyKpO2EsO2XjO2E" + "sC9Nb25zdGVySHVudFNraWxsQ29uZGl0aW9uVGFibGUucHJvdG8SE1Byb3Rv" + "LkRlc2lnbi5jb21tb24i0wEKHk1vbnN0ZXJIdW50U2tpbGxDb25kaXRpb25U" + "YWJsZRIcChRjb25kaXRpb25Mb2NhbFRleHRJZBgBIAEoBRIXCg9jb25kaXRp" + "b25UYXJnZXQYAiABKAUSFQoNY29uZGl0aW9uVHlwZRgDIAEoBRIWCg5jb25k" + "aXRpb25WYWx1ZRgEIAEoARIKCgJpZBgFIAEoBRIYChBsaW1pdExvY2FsVGV4" + "dElkGAYgASgFEhEKCWxpbWl0VHlwZRgHIAEoBRISCgpsaW1pdFZhbHVlGAgg" + "ASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24u" + "Y29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MonsterHuntSkillConditionTable), MonsterHuntSkillConditionTable.Parser, new string[8] { "ConditionLocalTextId", "ConditionTarget", "ConditionType", "ConditionValue", "Id", "LimitLocalTextId", "LimitType", "LimitValue" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
