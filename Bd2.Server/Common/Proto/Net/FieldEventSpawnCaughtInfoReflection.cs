using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004552 RID: 17746
	public static class FieldEventSpawnCaughtInfoReflection
	{
		// Token: 0x17002E0B RID: 11787
		// (get) Token: 0x0601B86F RID: 112751 RVA: 0x007C99DA File Offset: 0x007C7BDA
		public static FileDescriptor Descriptor
		{
			get
			{
				return FieldEventSpawnCaughtInfoReflection.descriptor;
			}
		}

		// Token: 0x040154F3 RID: 87283
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidDb21tb25zL0ZpZWxkRXZlbnRTcGF3bkNhdWdodEluZm8ucHJvdG8SCXBy" + "b3RvLm5ldCJhChlGaWVsZEV2ZW50U3Bhd25DYXVnaHRJbmZvEhYKDnNwYXdu" + "X2V2ZW50X2lkGAEgASgFEhgKEG1vbnN0ZXJfZ3JvdXBfaWQYAiABKAUSEgoK" + "bW9uc3Rlcl9pZBgDIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FieldEventSpawnCaughtInfo), FieldEventSpawnCaughtInfo.Parser, new string[] { "SpawnEventId", "MonsterGroupId", "MonsterId" }, null, null, null, null)
		}));
	}
}
