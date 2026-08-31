using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldObjectResearchRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXF1ZXN0L0ZpZWxkT2JqZWN0UmVzZWFyY2hSZXF1ZXN0LnByb3RvEglwcm90by5uZXQiTQoaRmllbGRPYmplY3RSZXNlYXJjaFJlcXVlc3QSCwoDc2VxGAEgASgFEg8KB3BhY2tfaWQYAiABKAUSEQoJb2JqZWN0X2lkGAMgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldObjectResearchRequest), FieldObjectResearchRequest.Parser, new string[3] { "Seq", "PackId", "ObjectId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
