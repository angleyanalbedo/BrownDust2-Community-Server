using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldObjectRespawnResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilSZXNwb25zZS9GaWVsZE9iamVjdFJlc3Bhd25SZXNwb25zZS5wcm90bxIJ" + "cHJvdG8ubmV0Gh9Db21tb25zL0ZpZWxkT2JqZWN0REJJbmZvLnByb3RvGiZD" + "b21tb25zL0ZpZWxkT2JqZWN0UmVzcGF3bkRCSW5mby5wcm90byKdAQoaRmll" + "bGRPYmplY3RSZXNwYXduUmVzcG9uc2USNwoRZmllbGRfb2JqZWN0X2luZm8Y" + "ASADKAsyHC5wcm90by5uZXQuRmllbGRPYmplY3REQkluZm8SRgoZZmllbGRf" + "b2JqZWN0X3Jlc3Bhd25faW5mbxgCIAMoCzIjLnByb3RvLm5ldC5GaWVsZE9i" + "amVjdFJlc3Bhd25EQkluZm9iBnByb3RvMw=="), new FileDescriptor[2]
	{
		FieldObjectDBInfoReflection.Descriptor,
		FieldObjectRespawnDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldObjectRespawnResponse), FieldObjectRespawnResponse.Parser, new string[2] { "FieldObjectInfo", "FieldObjectRespawnInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
