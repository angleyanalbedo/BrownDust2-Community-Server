using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipOptionReRollResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9FcXVpcE9wdGlvblJlUm9sbFJlc3BvbnNlLnByb3RvEglw" + "cm90by5uZXQaHUNvbW1vbnMvRXF1aXBPcHRpb25JbmZvLnByb3RvInwKGUVx" + "dWlwT3B0aW9uUmVSb2xsUmVzcG9uc2USLwoLbWFpbl9vcHRpb24YASADKAsy" + "Gi5wcm90by5uZXQuRXF1aXBPcHRpb25JbmZvEi4KCnN1Yl9vcHRpb24YAiAD" + "KAsyGi5wcm90by5uZXQuRXF1aXBPcHRpb25JbmZvYgZwcm90bzM="), new FileDescriptor[1] { EquipOptionInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipOptionReRollResponse), EquipOptionReRollResponse.Parser, new string[2] { "MainOption", "SubOption" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
