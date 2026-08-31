using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C8D RID: 31885
	public static class FishingFishTableReflection
	{
		// Token: 0x17011204 RID: 70148
		// (get) Token: 0x06046C37 RID: 289847 RVA: 0x011358E2 File Offset: 0x01133AE2
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingFishTableReflection.descriptor;
			}
		}

		// Token: 0x0402EAB7 RID: 191159
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CjFjb21tb24uZGIvRmlzaGluZ19fX+uCmuyLnC9GaXNoaW5nRmlzaFRhYmxl", "LnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIoMEChBGaXNoaW5nRmlzaFRh", "YmxlEhgKEGFxdWFyaXVtQmdtUGFyYW0YASABKAUSGwoTY3JpdGljYWxIaXR6", "b25lU2l6ZRgCIAEoBRIXCg9kZXNjTG9jYWxUZXh0SWQYAyABKAUSCwoDZXhw", "GAQgASgFEhMKC2Zpc2hTa2lsbElkGAUgAygFEhoKEmZpc2hUcmFwUHJpY2VD", "b3VudBgGIAEoBRIXCg9maXNoVHJhcFByaWNlSWQYByABKAUSGQoRZmlzaFRy", "YXBQcmljZVR5cGUYCCABKAUSDQoFZ3JhZGUYCSABKAUSFgoOaGFiaXRhdEdy", "b3VwSWQYCiABKAUSFgoOaWNvblNwcml0ZU5hbWUYCyABKAkSCgoCaWQYDCAB", "KAUSGAoQbG9ja2VkSWNvblNwcml0ZRgNIAEoCRIPCgdtYXhTaXplGA4gASgB", "Eg8KB21pblNpemUYDyABKAESEgoKbmFtZVRleHRJZBgQIAEoBRIZChFub3Jt",
			"YWxIaXR6b25lU2l6ZRgRIAEoBRINCgVwb3dlchgSIAEoARISCgpwcmVmYWJO", "YW1lGBMgASgJEhoKEnNwZWNpYWxNb3Rpb25Tb3VuZBgUIAEoCRIXCg9zcGVl", "ZE11bHRpcGxpZXIYFSABKAESDwoHc3RhbWluYRgWIAEoBRIOCgZ0aW1lSWQY", "FyABKAVCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2ln", "bi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingFishTable), FishingFishTable.Parser, new string[]
			{
				"AquariumBgmParam", "CriticalHitzoneSize", "DescLocalTextId", "Exp", "FishSkillId", "FishTrapPriceCount", "FishTrapPriceId", "FishTrapPriceType", "Grade", "HabitatGroupId",
				"IconSpriteName", "Id", "LockedIconSprite", "MaxSize", "MinSize", "NameTextId", "NormalHitzoneSize", "Power", "PrefabName", "SpecialMotionSound",
				"SpeedMultiplier", "Stamina", "TimeId"
			}, null, null, null, null)
		}));
	}
}
