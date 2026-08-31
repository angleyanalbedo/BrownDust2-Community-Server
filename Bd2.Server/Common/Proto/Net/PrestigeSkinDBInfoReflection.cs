using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200470F RID: 18191
	public static class PrestigeSkinDBInfoReflection
	{
		// Token: 0x170032FD RID: 13053
		// (get) Token: 0x0601CA61 RID: 117345 RVA: 0x007FA5D5 File Offset: 0x007F87D5
		public static FileDescriptor Descriptor
		{
			get
			{
				return PrestigeSkinDBInfoReflection.descriptor;
			}
		}

		// Token: 0x04015F18 RID: 89880
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBDb21tb25zL1ByZXN0aWdlU2tpbkRCSW5mby5wcm90bxIJcHJvdG8ubmV0" + "IlMKElByZXN0aWdlU2tpbkRCSW5mbxISCgpjb3N0dW1lX2lkGAEgASgFEhkK" + "EWNvc3R1bWVfZGVzaWduX2lkGAIgASgFEg4KBmlzX3NldBgDIAEoCGIGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PrestigeSkinDBInfo), PrestigeSkinDBInfo.Parser, new string[] { "CostumeId", "CostumeDesignId", "IsSet" }, null, null, null, null)
		}));
	}
}
