using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleDeckSaveRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXF1ZXN0L1B2cEJhdHRsZURlY2tTYXZlUmVxdWVzdC5wcm90bxIJcHJv" + "dG8ubmV0GiNDb21tb25zL1B2cEJhdHRsZVVzZXJEZWNrSW5mby5wcm90byJv" + "ChhQdnBCYXR0bGVEZWNrU2F2ZVJlcXVlc3QSCwoDc2VxGAEgASgFEhEKCWRl" + "Y2tfdHlwZRgCIAEoBRIzCglkZWNrX2luZm8YAyADKAsyIC5wcm90by5uZXQu" + "UHZwQmF0dGxlVXNlckRlY2tJbmZvYgZwcm90bzM="), new FileDescriptor[1] { PvpBattleUserDeckInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleDeckSaveRequest), PvpBattleDeckSaveRequest.Parser, new string[3] { "Seq", "DeckType", "DeckInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
