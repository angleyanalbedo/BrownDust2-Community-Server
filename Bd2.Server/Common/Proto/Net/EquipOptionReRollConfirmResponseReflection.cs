using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipOptionReRollConfirmResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci9SZXNwb25zZS9FcXVpcE9wdGlvblJlUm9sbENvbmZpcm1SZXNwb25zZS5w" + "cm90bxIJcHJvdG8ubmV0GhlDb21tb25zL0VxdWlwREJJbmZvLnByb3RvGhhD" + "b21tb25zL0NoYXJEQkluZm8ucHJvdG8ieAogRXF1aXBPcHRpb25SZVJvbGxD" + "b25maXJtUmVzcG9uc2USKgoKZXF1aXBfaW5mbxgBIAEoCzIWLnByb3RvLm5l" + "dC5FcXVpcERCSW5mbxIoCgljaGFyX2luZm8YAiABKAsyFS5wcm90by5uZXQu" + "Q2hhckRCSW5mb2IGcHJvdG8z"), new FileDescriptor[2]
	{
		EquipDBInfoReflection.Descriptor,
		CharDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipOptionReRollConfirmResponse), EquipOptionReRollConfirmResponse.Parser, new string[2] { "EquipInfo", "CharInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
