using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class MailInfoTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjNjb21tb24uZGIvSXRlbVRhYmxlX19f7JWE7J207YWcL01haWxJbmZvVGFi" + "bGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24ijgEKDU1haWxJbmZvVGFi" + "bGUSCgoCaWQYASABKAUSGgoSbWVzc2FnZUxvY2FsVGV4dElkGAIgASgFEhIK" + "CnBlcmlvZERhdGUYAyABKAUSGQoRc2VuZGVyTG9jYWxUZXh0SWQYBCABKAUS" + "GAoQdGl0bGVMb2NhbFRleHRJZBgFIAEoBRIMCgR0eXBlGAYgASgFQkRCE1By" + "b3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgIT" + "UHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MailInfoTable), MailInfoTable.Parser, new string[6] { "Id", "MessageLocalTextId", "PeriodDate", "SenderLocalTextId", "TitleLocalTextId", "Type" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
