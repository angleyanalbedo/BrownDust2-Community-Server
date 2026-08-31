using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class GachaRandomVisualTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjljb21tb24uZGIvR2FjaGFUYWJsZV9f672R6riwL0dhY2hhUmFuZG9tVmlz" + "dWFsVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iaAoWR2FjaGFS" + "YW5kb21WaXN1YWxUYWJsZRINCgVncmFkZRgBIAEoBRIKCgJpZBgCIAEoBRIW" + "Cg5yYW5kb21WaXN1YWxJZBgDIAMoBRINCgVyYXRpbxgEIAMoBRIMCgR0eXBl" + "GAUgASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNp" + "Z24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GachaRandomVisualTable), GachaRandomVisualTable.Parser, new string[5] { "Grade", "Id", "RandomVisualId", "Ratio", "Type" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
