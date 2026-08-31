using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C7E RID: 31870
	public static class FishingCollectionTableReflection
	{
		// Token: 0x170111A8 RID: 70056
		// (get) Token: 0x06046B41 RID: 289601 RVA: 0x011316A0 File Offset: 0x0112F8A0
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingCollectionTableReflection.descriptor;
			}
		}

		// Token: 0x0402EA0B RID: 190987
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "Cjdjb21tb24uZGIvRmlzaGluZ19fX+uCmuyLnC9GaXNoaW5nQ29sbGVjdGlv", "blRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIkQKFkZpc2hpbmdD", "b2xsZWN0aW9uVGFibGUSDgoGZmlzaElkGAEgASgFEgoKAmlkGAIgASgFEg4K", "BnNvcnRJZBgDIAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJv", "dG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3Rv", "Mw==" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingCollectionTable), FishingCollectionTable.Parser, new string[] { "FishId", "Id", "SortId" }, null, null, null, null)
		}));
	}
}
