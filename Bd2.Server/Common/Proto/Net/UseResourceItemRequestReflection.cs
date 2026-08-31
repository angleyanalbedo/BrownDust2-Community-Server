using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class UseResourceItemRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXF1ZXN0L1VzZVJlc291cmNlSXRlbVJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJjChZVc2VSZXNvdXJjZUl0ZW1SZXF1ZXN0EgsKA3NlcRgBIAEoBRITCgtpbnZlbl9pbmRleBgCIAEoAxIRCgl1c2VfY291bnQYAyABKAUSFAoMc2VsZWN0X3ZhbHVlGAQgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(UseResourceItemRequest), UseResourceItemRequest.Parser, new string[4] { "Seq", "InvenIndex", "UseCount", "SelectValue" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
