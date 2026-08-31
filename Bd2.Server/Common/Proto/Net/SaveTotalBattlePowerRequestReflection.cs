using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class SaveTotalBattlePowerRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilSZXF1ZXN0L1NhdmVUb3RhbEJhdHRsZVBvd2VyUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IkYKG1NhdmVUb3RhbEJhdHRsZVBvd2VyUmVxdWVzdBILCgNzZXEYASABKAUSGgoSdG90YWxfYmF0dGxlX3Bvd2VyGAIgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(SaveTotalBattlePowerRequest), SaveTotalBattlePowerRequest.Parser, new string[2] { "Seq", "TotalBattlePower" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
