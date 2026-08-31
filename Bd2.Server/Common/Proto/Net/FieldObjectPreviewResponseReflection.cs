using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldObjectPreviewResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilSZXNwb25zZS9GaWVsZE9iamVjdFByZXZpZXdSZXNwb25zZS5wcm90bxIJ" + "cHJvdG8ubmV0Gh9Db21tb25zL0ZpZWxkT2JqZWN0REJJbmZvLnByb3RvIngK" + "GkZpZWxkT2JqZWN0UHJldmlld1Jlc3BvbnNlEj4KGGZpZWxkX3Jld2FyZF9v" + "YnRhaW5faW5mbxgBIAMoCzIcLnByb3RvLm5ldC5GaWVsZE9iamVjdERCSW5m" + "bxIaChJyZXNlYXJjaF9vYmplY3RfaWQYAiADKAViBnByb3RvMw=="), new FileDescriptor[1] { FieldObjectDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldObjectPreviewResponse), FieldObjectPreviewResponse.Parser, new string[2] { "FieldRewardObtainInfo", "ResearchObjectId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
