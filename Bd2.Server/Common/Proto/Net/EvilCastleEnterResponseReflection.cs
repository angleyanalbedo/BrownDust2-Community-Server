using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleEnterResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXNwb25zZS9FdmlsQ2FzdGxlRW50ZXJSZXNwb25zZS5wcm90bxIJcHJv" + "dG8ubmV0GhtDb21tb25zL01vbnN0ZXJEQkluZm8ucHJvdG8aGENvbW1vbnMv" + "Q2hhckRCSW5mby5wcm90bxoYQ29tbW9ucy9EZWNrREJJbmZvLnByb3RvIp0B" + "ChdFdmlsQ2FzdGxlRW50ZXJSZXNwb25zZRIuCgxtb25zdGVyX2luZm8YASAD" + "KAsyGC5wcm90by5uZXQuTW9uc3RlckRCSW5mbxIoCgljaGFyX2luZm8YAiAD" + "KAsyFS5wcm90by5uZXQuQ2hhckRCSW5mbxIoCglkZWNrX2luZm8YAyADKAsy" + "FS5wcm90by5uZXQuRGVja0RCSW5mb2IGcHJvdG8z"), new FileDescriptor[3]
	{
		MonsterDBInfoReflection.Descriptor,
		CharDBInfoReflection.Descriptor,
		DeckDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleEnterResponse), EvilCastleEnterResponse.Parser, new string[3] { "MonsterInfo", "CharInfo", "DeckInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
