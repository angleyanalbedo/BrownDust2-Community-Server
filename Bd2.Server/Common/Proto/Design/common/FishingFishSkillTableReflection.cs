using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C8A RID: 31882
	public static class FishingFishSkillTableReflection
	{
		// Token: 0x170111F6 RID: 70134
		// (get) Token: 0x06046C0D RID: 289805 RVA: 0x01134F61 File Offset: 0x01133161
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingFishSkillTableReflection.descriptor;
			}
		}

		// Token: 0x0402EA9F RID: 191135
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CjZjb21tb24uZGIvRmlzaGluZ19fX+uCmuyLnC9GaXNoaW5nRmlzaFNraWxs", "VGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24i3AEKFUZpc2hpbmdG", "aXNoU2tpbGxUYWJsZRIQCghkdXJhdGlvbhgBIAEoARIKCgJpZBgCIAEoBRIT", "CgtwZW5hbHR5VHlwZRgDIAEoBRIUCgxwZW5hbHR5VmFsdWUYBCABKAESFAoM", "cmVtb3ZhbFZhbHVlGAUgASgFEhIKCnNraWxsQ291bnQYBiABKAUSEQoJc2tp", "bGxUeXBlGAcgASgFEhIKCnNraWxsVmFsdWUYCCABKAESEwoLdHJpZ2dlclR5", "cGUYCSABKAUSFAoMdHJpZ2dlclZhbHVlGAogASgBQkRCE1Byb3RvLkRlc2ln", "bi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVz", "aWduLmNvbW1vbmIGcHJvdG8z" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingFishSkillTable), FishingFishSkillTable.Parser, new string[] { "Duration", "Id", "PenaltyType", "PenaltyValue", "RemovalValue", "SkillCount", "SkillType", "SkillValue", "TriggerType", "TriggerValue" }, null, null, null, null)
		}));
	}
}
