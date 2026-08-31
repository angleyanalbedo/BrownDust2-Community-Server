using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class CommunityDefineTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkRjb21tb24uZGIvR2FtZURlZmF1bHRUYWJsZV9fX+q4sOuzuOyEpOyglS9D" + "b21tdW5pdHlEZWZpbmVUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1v" + "biKwAQoUQ29tbXVuaXR5RGVmaW5lVGFibGUSGwoTZnJpZW5kU2VuZEV4cGly" + "ZURheRgBIAEoBRIKCgJpZBgCIAEoBRIWCg5tYXhGcmllbmRDb3VudBgDIAEo" + "BRIfChdtYXhGcmllbmRSZWNvbW1lbmRDb3VudBgEIAEoBRIaChJtYXhGcmll" + "bmRSZWN2Q291bnQYBSABKAUSGgoSbWF4RnJpZW5kU2VuZENvdW50GAYgASgF" + "QkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29t" + "bW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CommunityDefineTable), CommunityDefineTable.Parser, new string[6] { "FriendSendExpireDay", "Id", "MaxFriendCount", "MaxFriendRecommendCount", "MaxFriendRecvCount", "MaxFriendSendCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
