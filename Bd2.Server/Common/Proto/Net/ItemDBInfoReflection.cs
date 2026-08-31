using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ItemDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhDb21tb25zL0l0ZW1EQkluZm8ucHJvdG8SCXByb3RvLm5ldBohQ29tbW9u" + "cy9QaWN0b3JpYWxCb29rREJJbmZvLnByb3RvIuYBCgpJdGVtREJJbmZvEhMK" + "C2ludmVuX2luZGV4GAEgASgDEgoKAmlkGAIgASgFEgwKBHR5cGUYAyABKAUS" + "DQoFY291bnQYBCABKAUSEQoJa2VlcF9mbGFnGAUgASgFEhIKCnRpbWVfdmFs" + "dWUYBiABKAMSOgoScGljdG9yaWFsYm9va19pbmZvGAcgASgLMh4ucHJvdG8u" + "bmV0LlBpY3RvcmlhbEJvb2tEQkluZm8SEwoLZXhwaXJ5X3RpbWUYCCABKAMS" + "DwoHc29ydF9pZBgJIAEoBRIRCgl1c2VfY291bnQYCiABKAViBnByb3RvMw=="), new FileDescriptor[1] { PictorialBookDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ItemDBInfo), ItemDBInfo.Parser, new string[10] { "InvenIndex", "Id", "Type", "Count", "KeepFlag", "TimeValue", "PictorialbookInfo", "ExpiryTime", "SortId", "UseCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
