using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class PvpSeasonTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjZjb21tb24uZGIvUFZQVGFibGVfX1/qsbDsmrjsoITsn4EvUHZwU2Vhc29u" + "VGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iLAoOUHZwU2Vhc29u" + "VGFibGUSCgoCaWQYASABKAUSDgoGc2Vhc29uGAIgASgFQkRCE1Byb3RvLkRl" + "c2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8u" + "RGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpSeasonTable), PvpSeasonTable.Parser, new string[2] { "Id", "Season" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
