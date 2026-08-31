using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleStageRankingInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci9SZXF1ZXN0L0V2aWxDYXN0bGVTdGFnZVJhbmtpbmdJbmZvUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0ImYKIUV2aWxDYXN0bGVTdGFnZVJhbmtpbmdJbmZvUmVxdWVzdBILCgNzZXEYASABKAUSDwoHcGFja19pZBgCIAEoBRIOCgZzZWFzb24YAyABKAUSEwoLc3RhZ2VfaW5kZXgYBCABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleStageRankingInfoRequest), EvilCastleStageRankingInfoRequest.Parser, new string[4] { "Seq", "PackId", "Season", "StageIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
