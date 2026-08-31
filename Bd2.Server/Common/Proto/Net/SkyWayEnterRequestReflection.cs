using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class SkyWayEnterRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXF1ZXN0L1NreVdheUVudGVyUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0ImEKElNreVdheUVudGVyUmVxdWVzdBILCgNzZXEYASABKAUSDwoHcGFja19pZBgCIAEoBRIQCghncm91cF9pZBgDIAEoBRIKCgJpZBgEIAEoBRIPCgdpc19hdXRvGAUgASgIYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(SkyWayEnterRequest), SkyWayEnterRequest.Parser, new string[5] { "Seq", "PackId", "GroupId", "Id", "IsAuto" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
