using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CharImprintLevelUpRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXF1ZXN0L0NoYXJJbXByaW50TGV2ZWxVcFJlcXVlc3QucHJvdG8SCXBy" + "b3RvLm5ldBoYQ29tbW9ucy9JdGVtREJJbmZvLnByb3RvIpABChlDaGFySW1w" + "cmludExldmVsVXBSZXF1ZXN0EgsKA3NlcRgBIAEoBRIYChBjaGFyX2ludmVu" + "X2luZGV4GAIgASgDEgwKBHNsb3QYAyABKAUSFAoMdGFyZ2V0X2xldmVsGAQg" + "ASgFEigKCWl0ZW1faW5mbxgFIAMoCzIVLnByb3RvLm5ldC5JdGVtREJJbmZv" + "YgZwcm90bzM="), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharImprintLevelUpRequest), CharImprintLevelUpRequest.Parser, new string[5] { "Seq", "CharInvenIndex", "Slot", "TargetLevel", "ItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
