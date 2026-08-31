using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EventHubSettingDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNDb21tb25zL0V2ZW50SHViU2V0dGluZ0RCSW5mby5wcm90bxIJcHJvdG8ubmV0IlIKFUV2ZW50SHViU2V0dGluZ0RCSW5mbxIMCgRzbG90GAEgASgFEhgKEGh1Yl9jb250ZW50X3R5cGUYAiABKAUSEQoJZXZlbnRfdWlkGAMgAygFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EventHubSettingDBInfo), EventHubSettingDBInfo.Parser, new string[3] { "Slot", "HubContentType", "EventUid" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
