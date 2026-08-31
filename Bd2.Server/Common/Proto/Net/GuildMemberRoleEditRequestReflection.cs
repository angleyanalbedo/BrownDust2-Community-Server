using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildMemberRoleEditRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXF1ZXN0L0d1aWxkTWVtYmVyUm9sZUVkaXRSZXF1ZXN0LnByb3RvEglw" + "cm90by5uZXQaFENvbW1vbnMvRGVmaW5lLnByb3RvIm8KGkd1aWxkTWVtYmVy" + "Um9sZUVkaXRSZXF1ZXN0EgsKA3NlcRgBIAEoBRITCgtvd25lcl9pbmRleBgC" + "IAEoAxIvCgRyb2xlGAMgASgOMiEucHJvdG8ubmV0LkRlZmluZV9HdWlsZE1l" + "bWJlclJvbGViBnByb3RvMw=="), new FileDescriptor[1] { DefineReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildMemberRoleEditRequest), GuildMemberRoleEditRequest.Parser, new string[3] { "Seq", "OwnerIndex", "Role" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
