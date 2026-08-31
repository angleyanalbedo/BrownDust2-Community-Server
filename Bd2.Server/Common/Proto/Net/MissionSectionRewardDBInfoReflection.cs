using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MissionSectionRewardDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihDb21tb25zL01pc3Npb25TZWN0aW9uUmV3YXJkREJJbmZvLnByb3RvEglwcm90by5uZXQiPAoaTWlzc2lvblNlY3Rpb25SZXdhcmREQkluZm8SEgoKZ3JvdXBfdHlwZRgBIAEoBRIKCgJpZBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MissionSectionRewardDBInfo), MissionSectionRewardDBInfo.Parser, new string[2] { "GroupType", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
