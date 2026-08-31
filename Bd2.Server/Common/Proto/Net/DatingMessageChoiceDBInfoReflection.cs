using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200443C RID: 17468
	public static class DatingMessageChoiceDBInfoReflection
	{
		// Token: 0x17002CC4 RID: 11460
		// (get) Token: 0x0601B3DC RID: 111580 RVA: 0x007BAE91 File Offset: 0x007B9091
		public static FileDescriptor Descriptor
		{
			get
			{
				return DatingMessageChoiceDBInfoReflection.descriptor;
			}
		}

		// Token: 0x04014D49 RID: 85321
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidDb21tb25zL0RhdGluZ01lc3NhZ2VDaG9pY2VEQkluZm8ucHJvdG8SCXBy" + "b3RvLm5ldCJRChlEYXRpbmdNZXNzYWdlQ2hvaWNlREJJbmZvEhAKCGdyb3Vw" + "X2lkGAEgASgFEgoKAmlkGAIgASgFEhYKDnNlbGVjdF90ZXh0X2lkGAMgASgF" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DatingMessageChoiceDBInfo), DatingMessageChoiceDBInfo.Parser, new string[] { "GroupId", "Id", "SelectTextId" }, null, null, null, null)
		}));
	}
}
