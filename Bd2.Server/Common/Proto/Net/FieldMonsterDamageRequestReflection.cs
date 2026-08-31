using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldMonsterDamageRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXF1ZXN0L0ZpZWxkTW9uc3RlckRhbWFnZVJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCI8ChlGaWVsZE1vbnN0ZXJEYW1hZ2VSZXF1ZXN0EgsKA3NlcRgBIAEoBRISCgptb25zdGVyX2lkGAIgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldMonsterDamageRequest), FieldMonsterDamageRequest.Parser, new string[2] { "Seq", "MonsterId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
