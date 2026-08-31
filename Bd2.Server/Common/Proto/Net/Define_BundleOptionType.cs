using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_BundleOptionType
{
	[OriginalName("BUNDLE_OPTION_TYPE_NONE")]
	BundleOptionTypeNone,
	[OriginalName("BUNDLE_OPTION_TYPE_FHD")]
	BundleOptionTypeFhd,
	[OriginalName("BUNDLE_OPTION_TYPE_HD")]
	BundleOptionTypeHd,
	[OriginalName("BUNDLE_OPTION_TYPE_SD")]
	BundleOptionTypeSd
}
