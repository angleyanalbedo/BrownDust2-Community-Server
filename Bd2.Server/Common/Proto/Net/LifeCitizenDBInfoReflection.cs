using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004603 RID: 17923
	public static class LifeCitizenDBInfoReflection
	{
		// Token: 0x17003025 RID: 12325
		// (get) Token: 0x0601BFCF RID: 114639 RVA: 0x007DE003 File Offset: 0x007DC203
		public static FileDescriptor Descriptor
		{
			get
			{
				return LifeCitizenDBInfoReflection.descriptor;
			}
		}

		// Token: 0x04015844 RID: 88132
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "Ch9Db21tb25zL0xpZmVDaXRpemVuREJJbmZvLnByb3RvEglwcm90by5uZXQa", "HUNvbW1vbnMvQXZhdGFyVXNlREJJbmZvLnByb3RvInQKEUxpZmVDaXRpemVu", "REJJbmZvEhUKDWNpdGl6ZW5faW5kZXgYASABKAUSFwoPY2l0aXplbl9zbG90", "X2lkGAIgASgFEi8KC2F2YXRhcl9pbmZvGAMgASgLMhoucHJvdG8ubmV0LkF2", "YXRhclVzZURCSW5mb2IGcHJvdG8z" })), new FileDescriptor[] { AvatarUseDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LifeCitizenDBInfo), LifeCitizenDBInfo.Parser, new string[] { "CitizenIndex", "CitizenSlotId", "AvatarInfo" }, null, null, null, null)
		}));
	}
}
