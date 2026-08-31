using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class CharRecoveryTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkBjb21tb24uZGIvQ2hhclRhYmxlX19fQ2hhcl9Db3N0dW1lX1NraWxsL0No" + "YXJSZWNvdmVyeVRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIo4B" + "ChFDaGFyUmVjb3ZlcnlUYWJsZRIKCgJpZBgBIAEoBRIcChRyZWNvdmVyeUFk" + "ZEl0ZW1Db3VudBgCIAEoBRIZChFyZWNvdmVyeUl0ZW1Db3VudBgDIAEoBRIY" + "ChByZWNvdmVyeUl0ZW1UeXBlGAQgASgFEhoKEnJlY292ZXJ5U3F1YWRMZXZl" + "bBgFIAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVz" + "aWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharRecoveryTable), CharRecoveryTable.Parser, new string[5] { "Id", "RecoveryAddItemCount", "RecoveryItemCount", "RecoveryItemType", "RecoverySquadLevel" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
