using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class RLEventTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjZjb21tb24uZGIvUm9ndWVsaWtlX+uhnOq3uOudvOydtO2BrC9STEV2ZW50" + "VGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24i9gIKDFJMRXZlbnRU" + "YWJsZRIXCg9jaG9pY2UxRWZmZWN0SWQYASADKAUSGwoTY2hvaWNlMUZhaWxF" + "ZmZlY3RJZBgCIAMoBRIXCg9jaG9pY2UyRWZmZWN0SWQYAyADKAUSHAoUY2hv" + "aWNlRGVzY05hbWVUZXh0SWQYBCADKAUSIgoaY2hvaWNlRmFpbFJlc3VsdE5h" + "bWVUZXh0SWQYBSADKAUSHgoWY2hvaWNlUmVzdWx0TmFtZVRleHRJZBgGIAMo" + "BRISCgpjaG9pY2VUeXBlGAcgAygFEhsKE2V2ZW50RGVzY05hbWVUZXh0SWQY" + "CCABKAUSFwoPZXZlbnROYW1lVGV4dElkGAkgASgFEhgKEGV2ZW50U3VjY2Vz" + "c1JhdGUYCiADKAUSGAoQZXhpdENob2ljZVN3aXRjaBgLIAEoBRIaChJleGl0" + "RGVzY05hbWVUZXh0SWQYDCABKAUSDwoHZ3JvdXBJZBgNIAEoBRIKCgJpZBgO" + "IAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWdu" + "LmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(RLEventTable), RLEventTable.Parser, new string[14]
		{
			"Choice1EffectId", "Choice1FailEffectId", "Choice2EffectId", "ChoiceDescNameTextId", "ChoiceFailResultNameTextId", "ChoiceResultNameTextId", "ChoiceType", "EventDescNameTextId", "EventNameTextId", "EventSuccessRate",
			"ExitChoiceSwitch", "ExitDescNameTextId", "GroupId", "Id"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
