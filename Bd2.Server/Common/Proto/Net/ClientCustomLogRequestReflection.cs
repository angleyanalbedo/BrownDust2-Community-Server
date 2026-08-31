using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ClientCustomLogRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXF1ZXN0L0NsaWVudEN1c3RvbUxvZ1JlcXVlc3QucHJvdG8SCXByb3Rv" + "Lm5ldCI1ChNDbGllbnRDdXN0b21Mb2dEYXRhEhAKCGxvZ190eXBlGAEgASgF" + "EgwKBGRhdGEYAiABKAkiVwoWQ2xpZW50Q3VzdG9tTG9nUmVxdWVzdBILCgNz" + "ZXEYASABKAUSMAoIbG9nX2RhdGEYAiADKAsyHi5wcm90by5uZXQuQ2xpZW50" + "Q3VzdG9tTG9nRGF0YWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[2]
	{
		new GeneratedClrTypeInfo(typeof(ClientCustomLogData), ClientCustomLogData.Parser, new string[2] { "LogType", "Data" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(ClientCustomLogRequest), ClientCustomLogRequest.Parser, new string[2] { "Seq", "LogData" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
