using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class PackEventListTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjhjb21tb24uZGIvRXZlbnRUYWJsZV9f7J2067Kk7Yq4L1BhY2tFdmVudExp" + "c3RUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiLaAQoSUGFja0V2" + "ZW50TGlzdFRhYmxlEhIKCmFjdGlvblR5cGUYASABKAkSGAoQYmdDaGFySWxs" + "dXN0TmFtZRgCIAEoCRIfChdldmVudEh1YkNvbnRlbnRJY29uTmFtZRgDIAEo" + "CRIPCgdncm91cElkGAQgASgFEh0KFWh1YkNvbnRlbnRMb2NhbFRleHRJZBgF" + "IAEoBRIWCg5odWJDb250ZW50VHlwZRgGIAEoBRIKCgJpZBgHIAEoBRIRCglz" + "bG90SW5kZXgYCCABKAUSDgoGc29ydElkGAkgASgFQkRCE1Byb3RvLkRlc2ln" + "bi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVz" + "aWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackEventListTable), PackEventListTable.Parser, new string[9] { "ActionType", "BgCharIllustName", "EventHubContentIconName", "GroupId", "HubContentLocalTextId", "HubContentType", "Id", "SlotIndex", "SortId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
