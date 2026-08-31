using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class MiniGameTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjRjb21tb24uZGIvUXVlc3RUYWJsZV9fX+2AmOyKpO2KuC9NaW5pR2FtZVRh" + "YmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIlYKDU1pbmlHYW1lVGFi" + "bGUSEwoLYW5zd2VySW5kZXgYASADKAUSEAoIZ2FtZVR5cGUYAiABKAUSCgoC" + "aWQYAyABKAUSEgoKcHJlZmFiTmFtZRgEIAEoCUJEQhNQcm90by5EZXNpZ24u" + "Y29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2ln" + "bi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameTable), MiniGameTable.Parser, new string[4] { "AnswerIndex", "GameType", "Id", "PrefabName" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
