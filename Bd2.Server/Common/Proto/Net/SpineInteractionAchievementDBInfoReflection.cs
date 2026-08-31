using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004779 RID: 18297
	public static class SpineInteractionAchievementDBInfoReflection
	{
		// Token: 0x17003421 RID: 13345
		// (get) Token: 0x0601CE82 RID: 118402 RVA: 0x0080557B File Offset: 0x0080377B
		public static FileDescriptor Descriptor
		{
			get
			{
				return SpineInteractionAchievementDBInfoReflection.descriptor;
			}
		}

		// Token: 0x040160F0 RID: 90352
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "Ci9Db21tb25zL1NwaW5lSW50ZXJhY3Rpb25BY2hpZXZlbWVudERCSW5mby5w", "cm90bxIJcHJvdG8ubmV0IpoBCiFTcGluZUludGVyYWN0aW9uQWNoaWV2ZW1l", "bnREQkluZm8SHAoUaW50ZXJhY3Rpb25fZ3JvdXBfaWQYASABKAUSEAoIZ3Jv", "dXBfaWQYAiABKAUSRQoKcG9pbnRfaW5mbxgDIAMoCzIxLnByb3RvLm5ldC5T", "cGluZUludGVyYWN0aW9uQWNoaWV2ZW1lbnRQb2ludERCSW5mbyJNCiZTcGlu", "ZUludGVyYWN0aW9uQWNoaWV2ZW1lbnRQb2ludERCSW5mbxIQCghwb2ludF9p", "ZBgBIAEoBRIRCgltb3Rpb25faWQYAiADKAViBnByb3RvMw==" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SpineInteractionAchievementDBInfo), SpineInteractionAchievementDBInfo.Parser, new string[] { "InteractionGroupId", "GroupId", "PointInfo" }, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(SpineInteractionAchievementPointDBInfo), SpineInteractionAchievementPointDBInfo.Parser, new string[] { "PointId", "MotionId" }, null, null, null, null)
		}));
	}
}
