using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRogueLikeMoveFloorResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjNSZXNwb25zZS9FdmlsQ2FzdGxlUm9ndWVMaWtlTW92ZUZsb29yUmVzcG9u" + "c2UucHJvdG8SCXByb3RvLm5ldBoqQ29tbW9ucy9FdmlsQ2FzdGxlUm9ndWVM" + "aWtlU3RhdGVJbmZvLnByb3RvGilDb21tb25zL0V2aWxDYXN0bGVSb2d1ZUxp" + "a2VSb29tSW5mby5wcm90byK5AQokRXZpbENhc3RsZVJvZ3VlTGlrZU1vdmVG" + "bG9vclJlc3BvbnNlEjsKCnN0YXRlX2luZm8YASABKAsyJy5wcm90by5uZXQu" + "RXZpbENhc3RsZVJvZ3VlTGlrZVN0YXRlSW5mbxITCgtjbGVhcl9mbG9vchgC" + "IAEoBRI/Cg9jbGVhcl9yb29tX2luZm8YAyABKAsyJi5wcm90by5uZXQuRXZp" + "bENhc3RsZVJvZ3VlTGlrZVJvb21JbmZvYgZwcm90bzM="), new FileDescriptor[2]
	{
		EvilCastleRogueLikeStateInfoReflection.Descriptor,
		EvilCastleRogueLikeRoomInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRogueLikeMoveFloorResponse), EvilCastleRogueLikeMoveFloorResponse.Parser, new string[3] { "StateInfo", "ClearFloor", "ClearRoomInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
