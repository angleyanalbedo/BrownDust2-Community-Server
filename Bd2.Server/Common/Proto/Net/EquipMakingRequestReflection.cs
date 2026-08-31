using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipMakingRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXF1ZXN0L0VxdWlwTWFraW5nUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0" + "GhhDb21tb25zL0l0ZW1EQkluZm8ucHJvdG8iiQEKEkVxdWlwTWFraW5nUmVx" + "dWVzdBILCgNzZXEYASABKAUSEwoLaW52ZW5faW5kZXgYAiABKAMSEQoJbWFr" + "aW5nX2lkGAMgASgFEhQKDG1ha2luZ19jb3VudBgEIAEoBRIoCglpdGVtX2lu" + "Zm8YBSADKAsyFS5wcm90by5uZXQuSXRlbURCSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipMakingRequest), EquipMakingRequest.Parser, new string[5] { "Seq", "InvenIndex", "MakingId", "MakingCount", "ItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
