using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class GachaVisualTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjNjb21tb24uZGIvR2FjaGFUYWJsZV9f672R6riwL0dhY2hhVmlzdWFsVGFi" + "bGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iYgoQR2FjaGFWaXN1YWxU" + "YWJsZRIKCgJpZBgBIAEoBRIMCgR0eXBlGAIgASgFEhkKEXZpc3VhbExvY2Fs" + "VGV4dElEGAMgASgFEhkKEXZvaWNlUmVzb3VyY2VOYW1lGAQgASgJQkRCE1By" + "b3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgIT" + "UHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GachaVisualTable), GachaVisualTable.Parser, new string[4] { "Id", "Type", "VisualLocalTextID", "VoiceResourceName" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
