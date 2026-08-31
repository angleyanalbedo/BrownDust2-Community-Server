using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleStageRankingInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjFSZXNwb25zZS9FdmlsQ2FzdGxlU3RhZ2VSYW5raW5nSW5mb1Jlc3BvbnNlLnByb3RvEglwcm90by5uZXQiagoiRXZpbENhc3RsZVN0YWdlUmFua2luZ0luZm9SZXNwb25zZRIMCgRyYW5rGAEgASgFEg0KBXBvaW50GAIgASgFEhIKCnRvdGFsX3JhbmsYAyABKAUSEwoLdG90YWxfcG9pbnQYBCABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleStageRankingInfoResponse), EvilCastleStageRankingInfoResponse.Parser, new string[4] { "Rank", "Point", "TotalRank", "TotalPoint" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
