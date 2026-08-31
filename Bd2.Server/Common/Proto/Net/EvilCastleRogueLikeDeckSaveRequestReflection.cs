using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRogueLikeDeckSaveRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjBSZXF1ZXN0L0V2aWxDYXN0bGVSb2d1ZUxpa2VEZWNrU2F2ZVJlcXVlc3Qu" + "cHJvdG8SCXByb3RvLm5ldBoYQ29tbW9ucy9EZWNrREJJbmZvLnByb3RvIlsK" + "IkV2aWxDYXN0bGVSb2d1ZUxpa2VEZWNrU2F2ZVJlcXVlc3QSCwoDc2VxGAEg" + "ASgFEigKCWRlY2tfaW5mbxgCIAMoCzIVLnByb3RvLm5ldC5EZWNrREJJbmZv" + "YgZwcm90bzM="), new FileDescriptor[1] { DeckDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRogueLikeDeckSaveRequest), EvilCastleRogueLikeDeckSaveRequest.Parser, new string[2] { "Seq", "DeckInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
