using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EventExchangeRewardRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXF1ZXN0L0V2ZW50RXhjaGFuZ2VSZXdhcmRSZXF1ZXN0LnByb3RvEglw" + "cm90by5uZXQaGENvbW1vbnMvSXRlbURCSW5mby5wcm90byKCAQoaRXZlbnRF" + "eGNoYW5nZVJld2FyZFJlcXVlc3QSCwoDc2VxGAEgASgFEhEKCWV2ZW50X3Vp" + "ZBgCIAEoBRIWCg5leGNoYW5nZV9jb3VudBgDIAEoBRIsCg11c2VfaXRlbV9p" + "bmZvGAQgAygLMhUucHJvdG8ubmV0Lkl0ZW1EQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EventExchangeRewardRequest), EventExchangeRewardRequest.Parser, new string[4] { "Seq", "EventUid", "ExchangeCount", "UseItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
