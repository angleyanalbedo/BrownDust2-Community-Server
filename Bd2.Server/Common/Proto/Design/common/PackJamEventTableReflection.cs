using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class PackJamEventTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjFjb21tb24uZGIvUGFja1RhYmxlX19f7YypL1BhY2tKYW1FdmVudFRhYmxl" + "LnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIoABChFQYWNrSmFtRXZlbnRU" + "YWJsZRIKCgJpZBgBIAEoBRIRCglpbnNlcnRNYXgYAiABKAUSEQoJaW5zZXJ0" + "TWluGAMgASgFEhMKC3Jld2FyZENvdW50GAQgASgFEhAKCHJld2FyZElkGAUg" + "ASgFEhIKCnJld2FyZFR5cGUYBiABKAVCREITUHJvdG8uRGVzaWduLmNvbW1v" + "blABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29t" + "bW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackJamEventTable), PackJamEventTable.Parser, new string[6] { "Id", "InsertMax", "InsertMin", "RewardCount", "RewardId", "RewardType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
