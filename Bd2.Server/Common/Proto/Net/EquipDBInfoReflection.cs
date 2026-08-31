using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlDb21tb25zL0VxdWlwREJJbmZvLnByb3RvEglwcm90by5uZXQaG0NvbW1v" + "bnMvRXF1aXBCYXNlSW5mby5wcm90bxohQ29tbW9ucy9QaWN0b3JpYWxCb29r" + "REJJbmZvLnByb3RvItQBCgtFcXVpcERCSW5mbxITCgtpbnZlbl9pbmRleBgB" + "IAEoAxIQCgh1c2VfY2hhchgCIAEoAxIRCglrZWVwX2ZsYWcYAyABKAUSEQoJ" + "bG9ja19mbGFnGAQgASgFEisKCWJhc2VfaW5mbxgFIAEoCzIYLnByb3RvLm5l" + "dC5FcXVpcEJhc2VJbmZvEjoKEnBpY3RvcmlhbGJvb2tfaW5mbxgGIAEoCzIe" + "LnByb3RvLm5ldC5QaWN0b3JpYWxCb29rREJJbmZvEg8KB3NvcnRfaWQYByAB" + "KAViBnByb3RvMw=="), new FileDescriptor[2]
	{
		EquipBaseInfoReflection.Descriptor,
		PictorialBookDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipDBInfo), EquipDBInfo.Parser, new string[7] { "InvenIndex", "UseChar", "KeepFlag", "LockFlag", "BaseInfo", "PictorialbookInfo", "SortId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
