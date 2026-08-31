using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PackPreviewInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXNwb25zZS9QYWNrUHJldmlld0luZm9SZXNwb25zZS5wcm90bxIJcHJv" + "dG8ubmV0GhlDb21tb25zL1F1ZXN0REJJbmZvLnByb3RvGh5Db21tb25zL1F1" + "ZXN0VGl0bGVEQkluZm8ucHJvdG8imgEKF1BhY2tQcmV2aWV3SW5mb1Jlc3Bv" + "bnNlEioKCnF1ZXN0X2luZm8YASADKAsyFi5wcm90by5uZXQuUXVlc3REQklu" + "Zm8SNQoQcXVlc3RfdGl0bGVfaW5mbxgCIAMoCzIbLnByb3RvLm5ldC5RdWVz" + "dFRpdGxlREJJbmZvEhwKFGlzX3BhY2tfZXZlbnRfcmV3YXJkGAMgASgIYgZw" + "cm90bzM="), new FileDescriptor[2]
	{
		QuestDBInfoReflection.Descriptor,
		QuestTitleDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackPreviewInfoResponse), PackPreviewInfoResponse.Parser, new string[3] { "QuestInfo", "QuestTitleInfo", "IsPackEventReward" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
