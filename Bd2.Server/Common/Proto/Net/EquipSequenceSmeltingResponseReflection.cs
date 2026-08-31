using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipSequenceSmeltingResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CixSZXNwb25zZS9FcXVpcFNlcXVlbmNlU21lbHRpbmdSZXNwb25zZS5wcm90" + "bxIJcHJvdG8ubmV0GhlDb21tb25zL0VxdWlwREJJbmZvLnByb3RvGhRDb21t" + "b25zL0RlZmluZS5wcm90bxoYQ29tbW9ucy9JdGVtREJJbmZvLnByb3RvGhhD" + "b21tb25zL0NoYXJEQkluZm8ucHJvdG8iqAIKHUVxdWlwU2VxdWVuY2VTbWVs" + "dGluZ1Jlc3BvbnNlEioKCmVxdWlwX2luZm8YASABKAsyFi5wcm90by5uZXQu" + "RXF1aXBEQkluZm8SKAoJY2hhcl9pbmZvGAIgASgLMhUucHJvdG8ubmV0LkNo" + "YXJEQkluZm8SPQoLcmVzdWx0X3R5cGUYAyABKA4yKC5wcm90by5uZXQuRGVm" + "aW5lX0VxdWlwVXBncmFkZVJlc3VsdFR5cGUSEQoJdHJ5X2NvdW50GAQgASgF" + "EjAKEWNvbnN1bWVfaXRlbV9pbmZvGAUgAygLMhUucHJvdG8ubmV0Lkl0ZW1E" + "QkluZm8SLQoObGFja19pdGVtX2luZm8YBiADKAsyFS5wcm90by5uZXQuSXRl" + "bURCSW5mb2IGcHJvdG8z"), new FileDescriptor[4]
	{
		EquipDBInfoReflection.Descriptor,
		DefineReflection.Descriptor,
		ItemDBInfoReflection.Descriptor,
		CharDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipSequenceSmeltingResponse), EquipSequenceSmeltingResponse.Parser, new string[6] { "EquipInfo", "CharInfo", "ResultType", "TryCount", "ConsumeItemInfo", "LackItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
