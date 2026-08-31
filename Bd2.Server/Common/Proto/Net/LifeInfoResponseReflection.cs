using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02005405 RID: 21509
	public static class LifeInfoResponseReflection
	{
		// Token: 0x17004F11 RID: 20241
		// (get) Token: 0x06023DA6 RID: 146854 RVA: 0x008F7855 File Offset: 0x008F5A55
		public static FileDescriptor Descriptor
		{
			get
			{
				return LifeInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x040187EF RID: 100335
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9SZXNwb25zZS9MaWZlSW5mb1Jlc3BvbnNlLnByb3RvEglwcm90by5uZXQa", "KENvbW1vbnMvTGlmZVdvcmxkT2JqZWN0UGxhY2VEQkluZm8ucHJvdG8aHENv", "bW1vbnMvTGlmZVVzZXJEQkluZm8ucHJvdG8aGENvbW1vbnMvSXRlbURCSW5m", "by5wcm90bxocQ29tbW9ucy9MaWZlVG9vbERCSW5mby5wcm90bxofQ29tbW9u", "cy9MaWZlRWF0Rm9vZERCSW5mby5wcm90bxofQ29tbW9ucy9MaWZlQ2l0aXpl", "bkRCSW5mby5wcm90bxoeQ29tbW9ucy9MaWZlSGVscGVyREJJbmZvLnByb3Rv", "GiNDb21tb25zL0xpZmVIZWxwZXJHYWNoYURCSW5mby5wcm90byKiBAoQTGlm", "ZUluZm9SZXNwb25zZRJAChFvYmplY3RfcGxhY2VfaW5mbxgBIAMoCzIlLnBy", "b3RvLm5ldC5MaWZlV29ybGRPYmplY3RQbGFjZURCSW5mbxIxCg5saWZlX3Vz", "ZXJfaW5mbxgCIAEoCzIZLnByb3RvLm5ldC5MaWZlVXNlckRCSW5mbxItCg5s",
			"aWZlX2l0ZW1faW5mbxgDIAMoCzIVLnByb3RvLm5ldC5JdGVtREJJbmZvEjQK", "FWxpZmVfZnVybmlzaGluZ3NfaW5mbxgEIAMoCzIVLnByb3RvLm5ldC5JdGVt", "REJJbmZvEjEKDmxpZmVfdG9vbF9pbmZvGAUgAygLMhkucHJvdG8ubmV0Lkxp", "ZmVUb29sREJJbmZvEj0KF2xpZmVfZHVyYXRpb25fYnVmZl9pbmZvGAYgAygL", "MhwucHJvdG8ubmV0LkxpZmVFYXRGb29kREJJbmZvEjcKEWxpZmVfY2l0aXpl", "bl9saXN0GAcgAygLMhwucHJvdG8ubmV0LkxpZmVDaXRpemVuREJJbmZvEhoK", "EmxpZmVfY29sbGVjdGlvbl9pZBgIIAMoBRIwCgtoZWxwZXJfaW5mbxgJIAMo", "CzIbLnByb3RvLm5ldC5MaWZlSGVscGVyREJJbmZvEjsKEWhlbHBlcl9nYWNo", "YV9pbmZvGAogAygLMiAucHJvdG8ubmV0LkxpZmVIZWxwZXJHYWNoYURCSW5m", "b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			LifeWorldObjectPlaceDBInfoReflection.Descriptor,
			LifeUserDBInfoReflection.Descriptor,
			ItemDBInfoReflection.Descriptor,
			LifeToolDBInfoReflection.Descriptor,
			LifeEatFoodDBInfoReflection.Descriptor,
			LifeCitizenDBInfoReflection.Descriptor,
			LifeHelperDBInfoReflection.Descriptor,
			LifeHelperGachaDBInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LifeInfoResponse), LifeInfoResponse.Parser, new string[] { "ObjectPlaceInfo", "LifeUserInfo", "LifeItemInfo", "LifeFurnishingsInfo", "LifeToolInfo", "LifeDurationBuffInfo", "LifeCitizenList", "LifeCollectionId", "HelperInfo", "HelperGachaInfo" }, null, null, null, null)
		}));
	}
}
