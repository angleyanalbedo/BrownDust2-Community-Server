using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXNwb25zZS9FcXVpcEluZm9SZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0" + "GhlDb21tb25zL0VxdWlwREJJbmZvLnByb3RvInoKEUVxdWlwSW5mb1Jlc3Bv" + "bnNlEioKCmVxdWlwX2luZm8YASADKAsyFi5wcm90by5uZXQuRXF1aXBEQklu" + "Zm8SOQoZZXF1aXBfb3B0aW9uX3JlX3JvbGxfaW5mbxgCIAEoCzIWLnByb3Rv" + "Lm5ldC5FcXVpcERCSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { EquipDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipInfoResponse), EquipInfoResponse.Parser, new string[2] { "EquipInfo", "EquipOptionReRollInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
