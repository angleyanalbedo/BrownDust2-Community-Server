using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class RLRelicTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjZjb21tb24uZGIvUm9ndWVsaWtlX+uhnOq3uOudvOydtO2BrC9STFJlbGlj" + "VGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24ivwEKDFJMUmVsaWNU" + "YWJsZRINCgVncmFkZRgBIAEoBRIKCgJpZBgCIAEoBRIRCglyZWxpY0J1ZmYY" + "AyADKAUSFwoPcmVsaWNEZXNjVGV4dElkGAQgASgFEhEKCXJlbGljSWNvbhgF" + "IAEoCRIVCg1yZWxpY0ljb25UeXBlGAYgASgFEhcKD3JlbGljTmFtZVRleHRJ" + "ZBgHIAEoBRISCgpyZWxpY1ByaWNlGAggASgFEhEKCXJlbGljVHlwZRgJIAEo" + "BUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNv" + "bW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(RLRelicTable), RLRelicTable.Parser, new string[9] { "Grade", "Id", "RelicBuff", "RelicDescTextId", "RelicIcon", "RelicIconType", "RelicNameTextId", "RelicPrice", "RelicType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
