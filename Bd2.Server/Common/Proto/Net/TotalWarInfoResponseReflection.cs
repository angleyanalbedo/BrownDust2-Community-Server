using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TotalWarInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXNwb25zZS9Ub3RhbFdhckluZm9SZXNwb25zZS5wcm90bxIJcHJvdG8u" + "bmV0GiBDb21tb25zL0JhdHRsZURhbWFnZURCSW5mby5wcm90byJ4ChRUb3Rh" + "bFdhckluZm9SZXNwb25zZRIxCgpzY29yZV9pbmZvGAEgAygLMh0ucHJvdG8u" + "bmV0LkJhdHRsZURhbWFnZURCSW5mbxITCgt0b3BfcGVyY2VudBgCIAEoARIY" + "ChB0b3BfcmFua2VyX3Njb3JlGAMgASgDYgZwcm90bzM="), new FileDescriptor[1] { BattleDamageDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TotalWarInfoResponse), TotalWarInfoResponse.Parser, new string[3] { "ScoreInfo", "TopPercent", "TopRankerScore" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
