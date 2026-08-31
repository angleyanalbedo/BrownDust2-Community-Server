using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004555 RID: 17749
	public static class FieldEventSpawnProgressInfoReflection
	{
		// Token: 0x17002E12 RID: 11794
		// (get) Token: 0x0601B88B RID: 112779 RVA: 0x007C9DB6 File Offset: 0x007C7FB6
		public static FileDescriptor Descriptor
		{
			get
			{
				return FieldEventSpawnProgressInfoReflection.descriptor;
			}
		}

		// Token: 0x040154FD RID: 87293
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CilDb21tb25zL0ZpZWxkRXZlbnRTcGF3blByb2dyZXNzSW5mby5wcm90bxIJ", "cHJvdG8ubmV0GidDb21tb25zL0ZpZWxkRXZlbnRTcGF3bkNhdWdodEluZm8u", "cHJvdG8isQEKG0ZpZWxkRXZlbnRTcGF3blByb2dyZXNzSW5mbxISCgpzdGFy", "dF90aW1lGAEgASgDEhkKEWV2ZW50X3NjaGVkdWxlX2lkGAIgASgFEhYKDnNw", "YXduX2V2ZW50X2lkGAMgASgFEhAKCGdyb3VwX2lkGAQgASgFEjkKC2NhdWdo", "dF9pbmZvGAUgAygLMiQucHJvdG8ubmV0LkZpZWxkRXZlbnRTcGF3bkNhdWdo", "dEluZm9iBnByb3RvMw==" })), new FileDescriptor[] { FieldEventSpawnCaughtInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FieldEventSpawnProgressInfo), FieldEventSpawnProgressInfo.Parser, new string[] { "StartTime", "EventScheduleId", "SpawnEventId", "GroupId", "CaughtInfo" }, null, null, null, null)
		}));
	}
}
