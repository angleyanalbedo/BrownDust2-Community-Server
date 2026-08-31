using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MyRoomTrophyDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBDb21tb25zL015Um9vbVRyb3BoeURCSW5mby5wcm90bxIJcHJvdG8ubmV0Im8KEk15Um9vbVRyb3BoeURCSW5mbxITCgtpbnZlbl9pbmRleBgBIAEoAxIKCgJpZBgCIAEoBRIVCg1jb250ZW50c190eXBlGAMgASgFEg4KBnNlYXNvbhgEIAEoBRIRCgl1c2VfY291bnQYBSABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MyRoomTrophyDBInfo), MyRoomTrophyDBInfo.Parser, new string[5] { "InvenIndex", "Id", "ContentsType", "Season", "UseCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
