using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class JoinUserRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1SZXF1ZXN0L0pvaW5Vc2VyUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0GhVD" + "b21tb25zL0VudkluZm8ucHJvdG8aFENvbW1vbnMvRGVmaW5lLnByb3RvIrQC" + "Cg9Kb2luVXNlclJlcXVlc3QSCwoDc2VxGAEgASgFEhQKDGFjY2Vzc190b2tl" + "bhgCIAEoCRITCgttYXJrZXRfdHlwZRgDIAEoBRIPCgd1c2VyX29zGAQgASgJ" + "EiQKCGVudl9pbmZvGAUgASgLMhIucHJvdG8ubmV0LkVudkluZm8SNQoNbGFu" + "Z3VhZ2VfdHlwZRgGIAEoDjIeLnByb3RvLm5ldC5EZWZpbmVfTGFuZ3VhZ2VU" + "eXBlEjsKE2xhbmd1YWdlX3NvdW5kX3R5cGUYByABKA4yHi5wcm90by5uZXQu" + "RGVmaW5lX0xhbmd1YWdlVHlwZRI+ChJidW5kbGVfb3B0aW9uX3R5cGUYCCAB" + "KA4yIi5wcm90by5uZXQuRGVmaW5lX0J1bmRsZU9wdGlvblR5cGViBnByb3Rv" + "Mw=="), new FileDescriptor[2]
	{
		EnvInfoReflection.Descriptor,
		DefineReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(JoinUserRequest), JoinUserRequest.Parser, new string[8] { "Seq", "AccessToken", "MarketType", "UserOs", "EnvInfo", "LanguageType", "LanguageSoundType", "BundleOptionType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
