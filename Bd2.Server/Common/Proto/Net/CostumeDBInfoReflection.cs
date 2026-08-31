using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CostumeDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtDb21tb25zL0Nvc3R1bWVEQkluZm8ucHJvdG8SCXByb3RvLm5ldBohQ29t" + "bW9ucy9QaWN0b3JpYWxCb29rREJJbmZvLnByb3RvIs8BCg1Db3N0dW1lREJJ" + "bmZvEhMKC2ludmVuX2luZGV4GAEgASgDEgoKAmlkGAIgASgFEg0KBWxldmVs" + "GAMgASgFEhAKCHVzZV9jaGFyGAQgASgDEjoKEnBpY3RvcmlhbGJvb2tfaW5m" + "bxgFIAMoCzIeLnByb3RvLm5ldC5QaWN0b3JpYWxCb29rREJJbmZvEg8KB3Nv" + "cnRfaWQYBiABKAUSGQoRdXNlX215X3Jvb21fY291bnQYByABKAUSFAoMcG90" + "ZW50aWFsX2lkGAggAygFYgZwcm90bzM="), new FileDescriptor[1] { PictorialBookDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CostumeDBInfo), CostumeDBInfo.Parser, new string[8] { "InvenIndex", "Id", "Level", "UseChar", "PictorialbookInfo", "SortId", "UseMyRoomCount", "PotentialId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
