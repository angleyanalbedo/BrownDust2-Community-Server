using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class LimitedCostumeTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkJjb21tb24uZGIvQ2hhclRhYmxlX19fQ2hhcl9Db3N0dW1lX1NraWxsL0xp" + "bWl0ZWRDb3N0dW1lVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24i" + "MgoTTGltaXRlZENvc3R1bWVUYWJsZRIPCgdlbmREYXRlGAEgASgJEgoKAmlk" + "GAIgASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNp" + "Z24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(LimitedCostumeTable), LimitedCostumeTable.Parser, new string[2] { "EndDate", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
