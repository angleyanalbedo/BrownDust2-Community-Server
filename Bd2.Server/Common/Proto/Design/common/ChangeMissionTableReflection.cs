using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class ChangeMissionTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjhjb21tb24uZGIvTWlzc2lvblRhYmxlX19f66+47IWYL0NoYW5nZU1pc3Np" + "b25UYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiJVChJDaGFuZ2VN" + "aXNzaW9uVGFibGUSDwoHZW5kRGF0ZRgBIAEoCRIPCgdncm91cElkGAIgASgF" + "EgoKAmlkGAMgASgFEhEKCXN0YXJ0RGF0ZRgEIAEoCUJEQhNQcm90by5EZXNp" + "Z24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRl" + "c2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ChangeMissionTable), ChangeMissionTable.Parser, new string[4] { "EndDate", "GroupId", "Id", "StartDate" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
