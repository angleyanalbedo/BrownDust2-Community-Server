using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200461E RID: 17950
	public static class LifeWorldObjectDBInfoReflection
	{
		// Token: 0x17003066 RID: 12390
		// (get) Token: 0x0601C0CD RID: 114893 RVA: 0x007E068F File Offset: 0x007DE88F
		public static FileDescriptor Descriptor
		{
			get
			{
				return LifeWorldObjectDBInfoReflection.descriptor;
			}
		}

		// Token: 0x040158A4 RID: 88228
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CiNDb21tb25zL0xpZmVXb3JsZE9iamVjdERCSW5mby5wcm90bxIJcHJvdG8u", "bmV0Is0BChVMaWZlV29ybGRPYmplY3REQkluZm8SCQoBeBgBIAEoBRIJCgF5", "GAIgASgFEg4KBnJvdGF0ZRgDIAEoBRINCgVpbmRleBgEIAEoBRIRCglvYmpl", "Y3RfaWQYBiABKAUSDgoGc3RhdHVzGAcgASgFEhIKCnN0YXJ0X3RpbWUYCCAB", "KAMSEAoIZW5kX3RpbWUYCSABKAMSNgoMaW5uZXJfb2JqZWN0GAogAygLMiAu", "cHJvdG8ubmV0LkxpZmVXb3JsZE9iamVjdERCSW5mb2IGcHJvdG8z" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LifeWorldObjectDBInfo), LifeWorldObjectDBInfo.Parser, new string[] { "X", "Y", "Rotate", "Index", "ObjectId", "Status", "StartTime", "EndTime", "InnerObject" }, null, null, null, null)
		}));
	}
}
