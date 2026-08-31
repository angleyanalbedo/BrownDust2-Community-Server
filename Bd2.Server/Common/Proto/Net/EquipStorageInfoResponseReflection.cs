using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipStorageInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXNwb25zZS9FcXVpcFN0b3JhZ2VJbmZvUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldBoZQ29tbW9ucy9FcXVpcERCSW5mby5wcm90byJGChhFcXVpcFN0b3JhZ2VJbmZvUmVzcG9uc2USKgoKZXF1aXBfaW5mbxgBIAMoCzIWLnByb3RvLm5ldC5FcXVpcERCSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { EquipDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipStorageInfoResponse), EquipStorageInfoResponse.Parser, new string[1] { "EquipInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
