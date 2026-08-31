using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipStoragePutResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXNwb25zZS9FcXVpcFN0b3JhZ2VQdXRSZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0GhlDb21tb25zL0VxdWlwREJJbmZvLnByb3RvIkUKF0VxdWlwU3RvcmFnZVB1dFJlc3BvbnNlEioKCmVxdWlwX2luZm8YASABKAsyFi5wcm90by5uZXQuRXF1aXBEQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { EquipDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipStoragePutResponse), EquipStoragePutResponse.Parser, new string[1] { "EquipInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
