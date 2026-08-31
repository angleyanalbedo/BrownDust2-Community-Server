using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PictorialBuffStatDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVDb21tb25zL1BpY3RvcmlhbEJ1ZmZTdGF0REJJbmZvLnByb3RvEglwcm90by5uZXQaFENvbW1vbnMvRGVmaW5lLnByb3RvImIKF1BpY3RvcmlhbEJ1ZmZTdGF0REJJbmZvEjMKCXN0YXRfdHlwZRgBIAEoDjIgLnByb3RvLm5ldC5EZWZpbmVfQ2hhclN0YXRPcHRpb24SEgoKc3RhdF92YWx1ZRgCIAEoAWIGcHJvdG8z"), new FileDescriptor[1] { DefineReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PictorialBuffStatDBInfo), PictorialBuffStatDBInfo.Parser, new string[2] { "StatType", "StatValue" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
