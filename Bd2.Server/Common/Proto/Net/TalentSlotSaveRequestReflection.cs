using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TalentSlotSaveRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXF1ZXN0L1RhbGVudFNsb3RTYXZlUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IjUKFVRhbGVudFNsb3RTYXZlUmVxdWVzdBILCgNzZXEYASABKAUSDwoHY2hhcl9pZBgCIAMoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TalentSlotSaveRequest), TalentSlotSaveRequest.Parser, new string[2] { "Seq", "CharId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
