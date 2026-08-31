using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldObjectRewardListRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXF1ZXN0L0ZpZWxkT2JqZWN0UmV3YXJkTGlzdFJlcXVlc3QucHJvdG8S" + "CXByb3RvLm5ldBohQ29tbW9ucy9GaWVsZE9iamVjdEJhc2VJbmZvLnByb3Rv" + "IncKHEZpZWxkT2JqZWN0UmV3YXJkTGlzdFJlcXVlc3QSCwoDc2VxGAEgASgF" + "Eg8KB3BhY2tfaWQYAiABKAUSOQoRZmllbGRfb2JqZWN0X2luZm8YAyADKAsy" + "Hi5wcm90by5uZXQuRmllbGRPYmplY3RCYXNlSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { FieldObjectBaseInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldObjectRewardListRequest), FieldObjectRewardListRequest.Parser, new string[3] { "Seq", "PackId", "FieldObjectInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
