using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MaintenanceInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXNwb25zZS9NYWludGVuYW5jZUluZm9SZXNwb25zZS5wcm90bxIJcHJv" + "dG8ubmV0Iq4CCg9NYWludGVuYW5jZUluZm8SEwoLbWFya2V0X3R5cGUYASAB" + "KAUSDwoHdmVyc2lvbhgCIAEoCRIWCg5idW5kbGVfdmVyc2lvbhgDIAEoCRIY" + "ChBpc19idW5kbGVfdXBkYXRlGAQgASgIEhgKEG1haW50ZW5hbmNlX3R5cGUY" + "BSABKAUSDAoEZGF0ZRgGIAEoCRITCgtyZWdpb25fbGlzdBgHIAEoCRIPCgd1" + "c2VfZHNhGAggASgREhcKD21haW50ZW5hbmNlX3VybBgJIAEoCRIbChN1c2Vf" + "bWFpbnRlbmFuY2VfdXJsGAogASgREhQKDGRvd25sb2FkX3VybBgLIAEoCRIO" + "CgZub3RpY2UYDCABKAkSGQoRYnVuZGxlX3ZlcnNpb25fc2QYDSABKAkikAEK" + "F01haW50ZW5hbmNlSW5mb1Jlc3BvbnNlEi8KC21hcmtldF9pbmZvGAEgASgL" + "MhoucHJvdG8ubmV0Lk1haW50ZW5hbmNlSW5mbxIbChNzZXJ2ZXJfY29ubmVj" + "dF9pbmZvGAIgASgJEhQKDGNvbm5lY3RfdHlwZRgDIAEoBRIRCgl1c2VyX3R5" + "cGUYBCABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[2]
	{
		new GeneratedClrTypeInfo(typeof(MaintenanceInfo), MaintenanceInfo.Parser, new string[13]
		{
			"MarketType", "Version", "BundleVersion", "IsBundleUpdate", "MaintenanceType", "Date", "RegionList", "UseDsa", "MaintenanceUrl", "UseMaintenanceUrl",
			"DownloadUrl", "Notice", "BundleVersionSd"
		}, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(MaintenanceInfoResponse), MaintenanceInfoResponse.Parser, new string[4] { "MarketInfo", "ServerConnectInfo", "ConnectType", "UserType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
