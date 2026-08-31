using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class QuestAcceptRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXF1ZXN0L1F1ZXN0QWNjZXB0UmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0ImwKElF1ZXN0QWNjZXB0UmVxdWVzdBILCgNzZXEYASABKAUSEAoIcXVlc3RfaWQYAiABKAUSDwoHcGFja19pZBgDIAEoBRITCgtxdWVzdF9sZXZlbBgEIAEoBRIRCglxdWVzdF9vcHQYBSABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(QuestAcceptRequest), QuestAcceptRequest.Parser, new string[5] { "Seq", "QuestId", "PackId", "QuestLevel", "QuestOpt" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
