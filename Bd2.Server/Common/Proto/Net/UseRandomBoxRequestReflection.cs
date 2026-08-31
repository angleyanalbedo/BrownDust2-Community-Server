using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class UseRandomBoxRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXF1ZXN0L1VzZVJhbmRvbUJveFJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJKChNVc2VSYW5kb21Cb3hSZXF1ZXN0EgsKA3NlcRgBIAEoBRITCgtpbnZlbl9pbmRleBgCIAEoAxIRCgl1c2VfY291bnQYAyABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(UseRandomBoxRequest), UseRandomBoxRequest.Parser, new string[3] { "Seq", "InvenIndex", "UseCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
