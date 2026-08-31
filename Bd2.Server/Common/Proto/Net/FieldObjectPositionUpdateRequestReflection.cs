using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldObjectPositionUpdateRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci5SZXF1ZXN0L0ZpZWxkT2JqZWN0UG9zaXRpb25VcGRhdGVSZXF1ZXN0LnBy" + "b3RvEglwcm90by5uZXQaJ0NvbW1vbnMvRmllbGRPYmplY3RQb3NpdGlvbkRC" + "SW5mby5wcm90byKdAQogRmllbGRPYmplY3RQb3NpdGlvblVwZGF0ZVJlcXVl" + "c3QSCwoDc2VxGAEgASgFEg8KB3BhY2tfaWQYAiABKAUSEAoIZ3JvdXBfaWQY" + "AyABKAUSEQoJb2JqZWN0X2lkGAQgASgFEjYKCHBvc2l0aW9uGAUgASgLMiQu" + "cHJvdG8ubmV0LkZpZWxkT2JqZWN0UG9zaXRpb25EQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { FieldObjectPositionDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldObjectPositionUpdateRequest), FieldObjectPositionUpdateRequest.Parser, new string[5] { "Seq", "PackId", "GroupId", "ObjectId", "Position" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
