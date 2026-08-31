using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GachaSelectionSaveRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXF1ZXN0L0dhY2hhU2VsZWN0aW9uU2F2ZVJlcXVlc3QucHJvdG8SCXBy" + "b3RvLm5ldBoiQ29tbW9ucy9HYWNoYVNlbGVjdGlvbkRCSW5mby5wcm90byJn" + "ChlHYWNoYVNlbGVjdGlvblNhdmVSZXF1ZXN0EgsKA3NlcRgBIAEoBRI9ChRn" + "YWNoYV9zZWxlY3Rpb25faW5mbxgCIAMoCzIfLnByb3RvLm5ldC5HYWNoYVNl" + "bGVjdGlvbkRCSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { GachaSelectionDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GachaSelectionSaveRequest), GachaSelectionSaveRequest.Parser, new string[2] { "Seq", "GachaSelectionInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
