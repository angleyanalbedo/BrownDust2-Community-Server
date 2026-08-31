using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_GachaSubType
{
	[OriginalName("GST_NONE")]
	GstNone,
	[OriginalName("GST_SELECTION")]
	GstSelection,
	[OriginalName("GST_ELEMENT")]
	GstElement,
	[OriginalName("GST_INFINITE")]
	GstInfinite,
	[OriginalName("GST_STEP_UP")]
	GstStepUp
}
