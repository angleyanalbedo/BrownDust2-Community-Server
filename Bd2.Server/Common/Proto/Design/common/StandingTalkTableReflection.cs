using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class StandingTalkTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkBjb21tb24uZGIvQ2hhclRhYmxlX19fQ2hhcl9Db3N0dW1lX1NraWxsL1N0" + "YW5kaW5nVGFsa1RhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIsAB" + "ChFTdGFuZGluZ1RhbGtUYWJsZRIZChFiYWNrZ3JvdW5kSW1nTmFtZRgBIAEo" + "CRIUCgxkaWFsb2dUZXh0SWQYAiABKAUSDwoHZ3JvdXBJZBgDIAEoBRIKCgJp" + "ZBgEIAEoBRIbChNpbGx1c3RDaGFyQW5pbWF0aW9uGAUgAygJEhoKEmlsbHVz" + "dFVuaXF1ZUNoYXJJZBgGIAMoBRINCgVzdGF0ZRgHIAEoBRIVCg10YWxrQ2hh" + "ckluZGV4GAggASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90" + "by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(StandingTalkTable), StandingTalkTable.Parser, new string[8] { "BackgroundImgName", "DialogTextId", "GroupId", "Id", "IllustCharAnimation", "IllustUniqueCharId", "State", "TalkCharIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
