using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipSmeltingResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXNwb25zZS9FcXVpcFNtZWx0aW5nUmVzcG9uc2UucHJvdG8SCXByb3Rv" + "Lm5ldBoZQ29tbW9ucy9FcXVpcERCSW5mby5wcm90bxoYQ29tbW9ucy9DaGFy" + "REJJbmZvLnByb3RvGhRDb21tb25zL0RlZmluZS5wcm90byLCAQoVRXF1aXBT" + "bWVsdGluZ1Jlc3BvbnNlEioKCmVxdWlwX2luZm8YASABKAsyFi5wcm90by5u" + "ZXQuRXF1aXBEQkluZm8SKAoJY2hhcl9pbmZvGAIgASgLMhUucHJvdG8ubmV0" + "LkNoYXJEQkluZm8SPQoLcmVzdWx0X3R5cGUYAyABKA4yKC5wcm90by5uZXQu" + "RGVmaW5lX0VxdWlwVXBncmFkZVJlc3VsdFR5cGUSFAoMcmVzdWx0X2dyYWRl" + "GAQgAygFYgZwcm90bzM="), new FileDescriptor[3]
	{
		EquipDBInfoReflection.Descriptor,
		CharDBInfoReflection.Descriptor,
		DefineReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipSmeltingResponse), EquipSmeltingResponse.Parser, new string[4] { "EquipInfo", "CharInfo", "ResultType", "ResultGrade" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
