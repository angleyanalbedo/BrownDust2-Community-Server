using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldObjectRewardRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXF1ZXN0L0ZpZWxkT2JqZWN0UmV3YXJkUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0InAKGEZpZWxkT2JqZWN0UmV3YXJkUmVxdWVzdBILCgNzZXEYASABKAUSDwoHcGFja19pZBgCIAEoBRIdChVmaWVsZF9vYmplY3RfZ3JvdXBfaWQYAyABKAUSFwoPZmllbGRfb2JqZWN0X2lkGAQgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldObjectRewardRequest), FieldObjectRewardRequest.Parser, new string[4] { "Seq", "PackId", "FieldObjectGroupId", "FieldObjectId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
