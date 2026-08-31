using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class UpdateUserContentsInfoOptionRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjFSZXF1ZXN0L1VwZGF0ZVVzZXJDb250ZW50c0luZm9PcHRpb25SZXF1ZXN0LnByb3RvEglwcm90by5uZXQiWwojVXBkYXRlVXNlckNvbnRlbnRzSW5mb09wdGlvblJlcXVlc3QSCwoDc2VxGAEgASgFEhYKDmlzX2FsbF9wcml2YXRlGAIgASgIEg8KB29wdGlvbnMYAyADKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(UpdateUserContentsInfoOptionRequest), UpdateUserContentsInfoOptionRequest.Parser, new string[3] { "Seq", "IsAllPrivate", "Options" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
