using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipSequenceUpgradeRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilSZXF1ZXN0L0VxdWlwU2VxdWVuY2VVcGdyYWRlUmVxdWVzdC5wcm90bxIJ" + "cHJvdG8ubmV0IqUBChtFcXVpcFNlcXVlbmNlVXBncmFkZVJlcXVlc3QSCwoD" + "c2VxGAEgASgFEhMKC2ludmVuX2luZGV4GAIgASgDEhUKDXVwZ3JhZGVfY291" + "bnQYAyABKAUSEwoLdXBncmFkZV9zZXEYBCABKAUSGgoSdXBncmFkZV9nb2xk" + "X2xpbWl0GAUgASgFEhwKFHVwZ3JhZGVfdGFyZ2V0X2xldmVsGAYgASgFYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipSequenceUpgradeRequest), EquipSequenceUpgradeRequest.Parser, new string[6] { "Seq", "InvenIndex", "UpgradeCount", "UpgradeSeq", "UpgradeGoldLimit", "UpgradeTargetLevel" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
