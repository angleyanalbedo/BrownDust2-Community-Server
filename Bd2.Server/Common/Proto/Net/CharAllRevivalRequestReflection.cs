using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CharAllRevivalRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXF1ZXN0L0NoYXJBbGxSZXZpdmFsUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IlkKFUNoYXJBbGxSZXZpdmFsUmVxdWVzdBILCgNzZXEYASABKAUSDwoHcGFja19pZBgCIAEoBRIOCgZucGNfaWQYAyABKAUSEgoKY2hhcl9pbmRleBgEIAMoA2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharAllRevivalRequest), CharAllRevivalRequest.Parser, new string[4] { "Seq", "PackId", "NpcId", "CharIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
