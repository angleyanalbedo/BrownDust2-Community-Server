using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class LobbyCutsceneTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkJjb21tb24uZGIvR2FtZURlZmF1bHRUYWJsZV9fX+q4sOuzuOyEpOyglS9M" + "b2JieUN1dHNjZW5lVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24i" + "zwEKEkxvYmJ5Q3V0c2NlbmVUYWJsZRInCh9jb3N0dW1lQ29uY2VwdEluZm9U" + "ZXh0RW51bUNvdW50GAEgAygFEiIKGmNvc3R1bWVDb25jZXB0SW5mb1RleHRU" + "eXBlGAIgAygFEigKIGNvc3R1bWVDb25jZXB0SW5mb1ZvaWNlRW51bUNvdW50" + "GAMgAygFEiMKG2Nvc3R1bWVDb25jZXB0SW5mb1ZvaWNlVHlwZRgEIAMoBRIR" + "Cgljb3N0dW1lSWQYBSABKAUSCgoCaWQYBiABKAVCREITUHJvdG8uRGVzaWdu" + "LmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNp" + "Z24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(LobbyCutsceneTable), LobbyCutsceneTable.Parser, new string[6] { "CostumeConceptInfoTextEnumCount", "CostumeConceptInfoTextType", "CostumeConceptInfoVoiceEnumCount", "CostumeConceptInfoVoiceType", "CostumeId", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
