using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PersonalInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXNwb25zZS9QZXJzb25hbEluZm9SZXNwb25zZS5wcm90bxIJcHJvdG8u" + "bmV0Il4KDlBlcnNvbmFsREJJbmZvEgoKAmlkGAEgASgFEg0KBXRpdGxlGAIg" + "ASgJEgsKA3VybBgDIAEoCRISCgpzdGFydF9kYXRlGAQgASgDEhAKCGVuZF9k" + "YXRlGAUgASgDIkgKFFBlcnNvbmFsSW5mb1Jlc3BvbnNlEjAKDXBlcnNvbmFs" + "X2luZm8YASADKAsyGS5wcm90by5uZXQuUGVyc29uYWxEQkluZm9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[2]
	{
		new GeneratedClrTypeInfo(typeof(PersonalDBInfo), PersonalDBInfo.Parser, new string[5] { "Id", "Title", "Url", "StartDate", "EndDate" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(PersonalInfoResponse), PersonalInfoResponse.Parser, new string[1] { "PersonalInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
