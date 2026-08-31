using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TrophyDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpDb21tb25zL1Ryb3BoeURCSW5mby5wcm90bxIJcHJvdG8ubmV0IlIKDFRyb3BoeURCSW5mbxITCgtpbnZlbl9pbmRleBgBIAEoAxIKCgJpZBgCIAEoBRIOCgZzZWFzb24YAyABKAUSEQoJdXNlX2NvdW50GAQgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TrophyDBInfo), TrophyDBInfo.Parser, new string[4] { "InvenIndex", "Id", "Season", "UseCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
