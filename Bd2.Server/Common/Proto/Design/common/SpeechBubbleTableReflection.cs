using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class SpeechBubbleTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkFjb21tb24uZGIvR2FtZURlZmF1bHRUYWJsZV9fX+q4sOuzuOyEpOyglS9T" + "cGVlY2hCdWJibGVUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiJG" + "ChFTcGVlY2hCdWJibGVUYWJsZRIKCgJpZBgBIAEoBRIRCglsb2NhbFRleHQY" + "AiABKAUSEgoKcmVtaW5kVHlwZRgDIAEoBUJEQhNQcm90by5EZXNpZ24uY29t" + "bW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5j" + "b21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(SpeechBubbleTable), SpeechBubbleTable.Parser, new string[3] { "Id", "LocalText", "RemindType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
