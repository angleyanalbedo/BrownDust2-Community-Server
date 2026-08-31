using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipUpgradeRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXF1ZXN0L0VxdWlwVXBncmFkZVJlcXVlc3QucHJvdG8SCXByb3RvLm5ldBoYQ29tbW9ucy9JdGVtREJJbmZvLnByb3RvImEKE0VxdWlwVXBncmFkZVJlcXVlc3QSCwoDc2VxGAEgASgFEhMKC2ludmVuX2luZGV4GAIgASgDEigKCWl0ZW1faW5mbxgDIAMoCzIVLnByb3RvLm5ldC5JdGVtREJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipUpgradeRequest), EquipUpgradeRequest.Parser, new string[3] { "Seq", "InvenIndex", "ItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
