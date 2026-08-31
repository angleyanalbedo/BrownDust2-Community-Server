using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class CharListTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjxjb21tb24uZGIvQ2hhclRhYmxlX19fQ2hhcl9Db3N0dW1lX1NraWxsL0No" + "YXJMaXN0VGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iSAoNQ2hh" + "ckxpc3RUYWJsZRIKCgJpZBgBIAEoBRINCgVtYXBJZBgCIAEoBRIOCgZwYWNr" + "SWQYAyABKAUSDAoEdHlwZRgEIAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9u" + "UAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21t" + "b25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharListTable), CharListTable.Parser, new string[4] { "Id", "MapId", "PackId", "Type" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
