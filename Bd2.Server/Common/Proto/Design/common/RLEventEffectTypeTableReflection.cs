using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class RLEventEffectTypeTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkBjb21tb24uZGIvUm9ndWVsaWtlX+uhnOq3uOudvOydtO2BrC9STEV2ZW50" + "RWZmZWN0VHlwZVRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIoMB" + "ChZSTEV2ZW50RWZmZWN0VHlwZVRhYmxlEhIKCmVmZmVjdFR5cGUYASABKAUS" + "FAoMZWZmZWN0VmFsdWUxGAIgASgFEhQKDGVmZmVjdFZhbHVlMhgDIAEoBRId" + "ChVldmVudEVmZmVjdE5hbWVUZXh0SWQYBCABKAUSCgoCaWQYBSABKAVCREIT" + "UHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26q" + "AhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(RLEventEffectTypeTable), RLEventEffectTypeTable.Parser, new string[5] { "EffectType", "EffectValue1", "EffectValue2", "EventEffectNameTextId", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
