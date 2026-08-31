using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class MyRoomItemEnumTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjZjb21tb24uZGIvTXlSb29tX19f66eI7J2066O4L015Um9vbUl0ZW1FbnVt" + "VGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iPwoTTXlSb29tSXRl" + "bUVudW1UYWJsZRINCgVncmlkWBgBIAEoBRINCgVncmlkWRgCIAEoBRIKCgJp" + "ZBgDIAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVz" + "aWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MyRoomItemEnumTable), MyRoomItemEnumTable.Parser, new string[3] { "GridX", "GridY", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
