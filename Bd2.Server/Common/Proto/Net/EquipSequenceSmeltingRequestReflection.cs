using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipSequenceSmeltingRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXF1ZXN0L0VxdWlwU2VxdWVuY2VTbWVsdGluZ1JlcXVlc3QucHJvdG8S" + "CXByb3RvLm5ldBoYQ29tbW9ucy9JdGVtREJJbmZvLnByb3RvInEKHEVxdWlw" + "U2VxdWVuY2VTbWVsdGluZ1JlcXVlc3QSCwoDc2VxGAEgASgFEhMKC2ludmVu" + "X2luZGV4GAIgASgDEhYKDnNtZWx0aW5nX2NvdW50GAMgASgFEhcKD2lzX3N1" + "Y2Nlc3Nfc3RvcBgEIAEoCGIGcHJvdG8z"), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipSequenceSmeltingRequest), EquipSequenceSmeltingRequest.Parser, new string[4] { "Seq", "InvenIndex", "SmeltingCount", "IsSuccessStop" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
