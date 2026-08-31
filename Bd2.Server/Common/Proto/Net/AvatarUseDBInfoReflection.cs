using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020043AA RID: 17322
	public static class AvatarUseDBInfoReflection
	{
		// Token: 0x17002A96 RID: 10902
		// (get) Token: 0x0601ACCC RID: 109772 RVA: 0x007A4AB0 File Offset: 0x007A2CB0
		public static FileDescriptor Descriptor
		{
			get
			{
				return AvatarUseDBInfoReflection.descriptor;
			}
		}

		// Token: 0x04014984 RID: 84356
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "Ch1Db21tb25zL0F2YXRhclVzZURCSW5mby5wcm90bxIJcHJvdG8ubmV0Ip4C", "Cg9BdmF0YXJVc2VEQkluZm8SEwoLdXNlX2NoYXJfaWQYASABKAUSEwoLdXNl", "X2hhaXJfaWQYAiABKAUSHQoVdXNlX2hhaXJfYWNjZXNzb3J5X2lkGAMgASgF", "Eh0KFXVzZV9mYWNlX2FjY2Vzc29yeV9pZBgEIAEoBRIWCg51c2VfY29zdHVt", "ZV9pZBgFIAEoBRIdChV1c2VfYm9keV9hY2Nlc3NvcnlfaWQYBiABKAUSHQoV", "dXNlX2hhbmRfYWNjZXNzb3J5X2lkGAcgASgFEhIKCnVzZV9wZXRfaWQYCCAB", "KAUSFAoMdXNlX21vdW50X2lkGAkgASgFEhUKDXVzZV9lZmZlY3RfaWQYCiAB", "KAUSDAoEZGF0ZRgLIAEoA2IGcHJvdG8z" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AvatarUseDBInfo), AvatarUseDBInfo.Parser, new string[]
			{
				"UseCharId", "UseHairId", "UseHairAccessoryId", "UseFaceAccessoryId", "UseCostumeId", "UseBodyAccessoryId", "UseHandAccessoryId", "UsePetId", "UseMountId", "UseEffectId",
				"Date"
			}, null, null, null, null)
		}));
	}
}
