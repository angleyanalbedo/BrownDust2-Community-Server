using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class BuffImmuneGroupTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjljb21tb24uZGIvQmF0dGxlVGFibGVfX1/soITtiKwvQnVmZkltbXVuZUdy" + "b3VwVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iiQEKFEJ1ZmZJ" + "bW11bmVHcm91cFRhYmxlEhUKDWJ1ZmZDbGFzc1R5cGUYASADKAkSFQoNYnVm" + "Zkdyb3VwVHlwZRgCIAMoBRIiChpidWZmSW1tdW5lQXBwbHlTa2lsbFRleHRJ" + "ZBgDIAMoBRITCgtidWZmU3ViVHlwZRgEIAMoBRIKCgJpZBgFIAEoBUJEQhNQ" + "cm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoC" + "E1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BuffImmuneGroupTable), BuffImmuneGroupTable.Parser, new string[5] { "BuffClassType", "BuffGroupType", "BuffImmuneApplySkillTextId", "BuffSubType", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
