using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MyRoomUserInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxDb21tb25zL015Um9vbVVzZXJJbmZvLnByb3RvEglwcm90by5uZXQaGkNv" + "bW1vbnMvTXlSb29tREJJbmZvLnByb3RvGiBDb21tb25zL015Um9vbVRyb3Bo" + "eURCSW5mby5wcm90bxobQ29tbW9ucy9Db3N0dW1lREJJbmZvLnByb3RvGhhD" + "b21tb25zL0l0ZW1EQkluZm8ucHJvdG8ipwIKDk15Um9vbVVzZXJJbmZvEhMK" + "C293bmVyX2luZGV4GAEgASgDEg8KB3VzZXJfaWQYAiABKAkSGwoTcG9ydHJh" + "aXRfY29zdHVtZV9pZBgDIAEoBRIaChJwcmltYXJ5X215X3Jvb21faWQYBCAB" + "KAUSKAoJaXRlbV9pbmZvGAUgAygLMhUucHJvdG8ubmV0Lkl0ZW1EQkluZm8S" + "LgoMY29zdHVtZV9pbmZvGAYgAygLMhgucHJvdG8ubmV0LkNvc3R1bWVEQklu" + "Zm8SMgoLdHJvcGh5X2luZm8YByADKAsyHS5wcm90by5uZXQuTXlSb29tVHJv" + "cGh5REJJbmZvEigKB215X3Jvb20YCCADKAsyFy5wcm90by5uZXQuTXlSb29t" + "REJJbmZvYgZwcm90bzM="), new FileDescriptor[4]
	{
		MyRoomDBInfoReflection.Descriptor,
		MyRoomTrophyDBInfoReflection.Descriptor,
		CostumeDBInfoReflection.Descriptor,
		ItemDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MyRoomUserInfo), MyRoomUserInfo.Parser, new string[8] { "OwnerIndex", "UserId", "PortraitCostumeId", "PrimaryMyRoomId", "ItemInfo", "CostumeInfo", "TrophyInfo", "MyRoom" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
