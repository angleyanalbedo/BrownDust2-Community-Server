using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class PackDefaultTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjBjb21tb24uZGIvUGFja1RhYmxlX19f7YypL1BhY2tEZWZhdWx0VGFibGUu" + "cHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iPQoQUGFja0RlZmF1bHRUYWJs" + "ZRIKCgJpZBgBIAEoBRIdChVwYWNrTG9hZGluZ1ByZWZhYk5hbWUYAiABKAlC" + "REITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21t" + "b26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackDefaultTable), PackDefaultTable.Parser, new string[2] { "Id", "PackLoadingPrefabName" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
