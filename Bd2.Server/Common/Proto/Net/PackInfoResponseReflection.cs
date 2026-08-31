using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PackInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXNwb25zZS9QYWNrSW5mb1Jlc3BvbnNlLnByb3RvEglwcm90by5uZXQa" + "GENvbW1vbnMvUGFja0RCSW5mby5wcm90bxoeQ29tbW9ucy9RdWVzdExldmVs" + "REJJbmZvLnByb3RvGiNDb21tb25zL1BhY2tDbGVhclJld2FyZERCSW5mby5w" + "cm90byK1AQoQUGFja0luZm9SZXNwb25zZRIoCglwYWNrX2luZm8YASADKAsy" + "FS5wcm90by5uZXQuUGFja0RCSW5mbxI1ChBxdWVzdF9sZXZlbF9pbmZvGAIg" + "AygLMhsucHJvdG8ubmV0LlF1ZXN0TGV2ZWxEQkluZm8SQAoWcGFja19jbGVh" + "cl9yZXdhcmRfaW5mbxgDIAMoCzIgLnByb3RvLm5ldC5QYWNrQ2xlYXJSZXdh" + "cmREQkluZm9iBnByb3RvMw=="), new FileDescriptor[3]
	{
		PackDBInfoReflection.Descriptor,
		QuestLevelDBInfoReflection.Descriptor,
		PackClearRewardDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackInfoResponse), PackInfoResponse.Parser, new string[3] { "PackInfo", "QuestLevelInfo", "PackClearRewardInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
