using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class WorldBuffTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjdjb21tb24uZGIvV29ybGRCdWZmX19f7JuU65Oc67KE7ZSEL1dvcmxkQnVm" + "ZlRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIo4BCg5Xb3JsZEJ1" + "ZmZUYWJsZRIQCghidWZmSWNvbhgBIAEoCRIcChRidWZmVGl0bGVMb2NhbFRl" + "eHRJZBgCIAEoBRIRCglidWZmVmFsdWUYAyABKAESGwoTYnVmZmRlc2NMb2Nh" + "bFRleHRJZBgEIAEoBRIKCgJpZBgFIAEoBRIQCghzdGF0VHlwZRgGIAEoBUJE" + "QhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1v" + "bqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(WorldBuffTable), WorldBuffTable.Parser, new string[6] { "BuffIcon", "BuffTitleLocalTextId", "BuffValue", "BuffdescLocalTextId", "Id", "StatType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
