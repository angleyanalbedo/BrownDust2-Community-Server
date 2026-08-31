using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class CharacterPictorialBookTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkJjb21tb24uZGIvUGljdG9yaWFsQm9va19fX+uPhOqwkC9DaGFyYWN0ZXJQ" + "aWN0b3JpYWxCb29rVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24i" + "nAEKG0NoYXJhY3RlclBpY3RvcmlhbEJvb2tUYWJsZRIOCgZjaGFySWQYASAD" + "KAUSGAoQY29sbGVjdGlvbkJ1ZmZJZBgCIAEoBRIcChRncm91cERlc2NMb2Nh" + "bFRleHRJZBgDIAEoBRIYChBncm91cExvY2FsVGV4dElkGAQgASgFEgoKAmlk" + "GAUgASgFEg8KB3RhYlR5cGUYBiABKAVCREITUHJvdG8uRGVzaWduLmNvbW1v" + "blABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29t" + "bW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharacterPictorialBookTable), CharacterPictorialBookTable.Parser, new string[6] { "CharId", "CollectionBuffId", "GroupDescLocalTextId", "GroupLocalTextId", "Id", "TabType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
