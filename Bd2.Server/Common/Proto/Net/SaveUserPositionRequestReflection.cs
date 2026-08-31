using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class SaveUserPositionRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXF1ZXN0L1NhdmVVc2VyUG9zaXRpb25SZXF1ZXN0LnByb3RvEglwcm90by5uZXQiTgoXU2F2ZVVzZXJQb3NpdGlvblJlcXVlc3QSCwoDc2VxGAEgASgFEg8KB3BhY2tfaWQYAiABKAUSFQoNcGFja19wb3NpdGlvbhgDIAEoCWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(SaveUserPositionRequest), SaveUserPositionRequest.Parser, new string[3] { "Seq", "PackId", "PackPosition" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
