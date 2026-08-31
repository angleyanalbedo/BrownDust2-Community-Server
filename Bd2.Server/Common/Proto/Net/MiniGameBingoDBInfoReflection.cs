using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameBingoDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFDb21tb25zL01pbmlHYW1lQmluZ29EQkluZm8ucHJvdG8SCXByb3RvLm5l" + "dBoUQ29tbW9ucy9EZWZpbmUucHJvdG8iegoTTWluaUdhbWVCaW5nb0RCSW5m" + "bxIZChFldmVudF9zY2hlZHVsZV9pZBgBIAEoBRITCgtjbGVhcl9jb3VudBgC" + "IAEoBRITCgtiaW5nb19ib2FyZBgDIAMoBRIeChZvcGVuX2JpbmdvX2JvYXJk" + "X2luZGV4GAQgAygFImcKFU1pbmlHYW1lQmluZ29MaW5lSW5mbxI6CglsaW5l" + "X3R5cGUYASABKA4yJy5wcm90by5uZXQuRGVmaW5lX01pbmlHYW1lQmluZ29M" + "aW5lVHlwZRISCgpsaW5lX2luZGV4GAIgASgFYgZwcm90bzM="), new FileDescriptor[1] { DefineReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[2]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameBingoDBInfo), MiniGameBingoDBInfo.Parser, new string[4] { "EventScheduleId", "ClearCount", "BingoBoard", "OpenBingoBoardIndex" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(MiniGameBingoLineInfo), MiniGameBingoLineInfo.Parser, new string[2] { "LineType", "LineIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
