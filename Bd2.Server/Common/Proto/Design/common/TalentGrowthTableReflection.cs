using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class TalentGrowthTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjxjb21tb24uZGIvVGFsZW50VGFibGVfX1/snqzriqXsiqTtgqwvVGFsZW50" + "R3Jvd3RoVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iiAEKEVRh" + "bGVudEdyb3d0aFRhYmxlEg8KB2dyb3VwSWQYASABKAUSFwoPZ3Jvd3RoSXRl" + "bUNvdW50GAIgAygFEhQKDGdyb3d0aEl0ZW1JZBgDIAMoBRIWCg5ncm93dGhJ" + "dGVtVHlwZRgEIAMoBRIKCgJpZBgFIAEoBRIPCgduZWVkRXhwGAYgASgFQkRC" + "E1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9u" + "qgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TalentGrowthTable), TalentGrowthTable.Parser, new string[6] { "GroupId", "GrowthItemCount", "GrowthItemId", "GrowthItemType", "Id", "NeedExp" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
