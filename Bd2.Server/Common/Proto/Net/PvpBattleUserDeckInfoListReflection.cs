using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleUserDeckInfoListReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidDb21tb25zL1B2cEJhdHRsZVVzZXJEZWNrSW5mb0xpc3QucHJvdG8SCXByb3RvLm5ldBojQ29tbW9ucy9QdnBCYXR0bGVVc2VyRGVja0luZm8ucHJvdG8iUAoZUHZwQmF0dGxlVXNlckRlY2tJbmZvTGlzdBIzCglkZWNrX2luZm8YASADKAsyIC5wcm90by5uZXQuUHZwQmF0dGxlVXNlckRlY2tJbmZvYgZwcm90bzM="), new FileDescriptor[1] { PvpBattleUserDeckInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleUserDeckInfoList), PvpBattleUserDeckInfoList.Parser, new string[1] { "DeckInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
