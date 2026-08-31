using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipBatchUseRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXF1ZXN0L0VxdWlwQmF0Y2hVc2VSZXF1ZXN0LnByb3RvEglwcm90by5u" + "ZXQaH0NvbW1vbnMvRXF1aXBCYXRjaFVzZUluZm8ucHJvdG8iWwoURXF1aXBC" + "YXRjaFVzZVJlcXVlc3QSCwoDc2VxGAEgASgFEjYKEGVxdWlwX2JhdGNoX2lu" + "Zm8YAiADKAsyHC5wcm90by5uZXQuRXF1aXBCYXRjaFVzZUluZm9iBnByb3Rv" + "Mw=="), new FileDescriptor[1] { EquipBatchUseInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipBatchUseRequest), EquipBatchUseRequest.Parser, new string[2] { "Seq", "EquipBatchInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
