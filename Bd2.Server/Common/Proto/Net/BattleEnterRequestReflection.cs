using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class BattleEnterRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXF1ZXN0L0JhdHRsZUVudGVyUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0" + "IvABChJCYXR0bGVFbnRlclJlcXVlc3QSCwoDc2VxGAEgASgFEhAKCGdyb3Vw" + "X2lkGAIgASgFEhIKCm1vbnN0ZXJfaWQYAyABKAUSEwoLYmF0dGxlX2RlY2sY" + "BCABKAUSEwoLYmF0dGxlX21vZGUYBSABKAUSFwoPbW9uc3Rlcl9odW50X2lk" + "GAYgASgFEhMKC2lzX2NvbnRpbnVlGAcgASgIEhwKFHN0YWdlX21hZ2ljX2dy" + "b3VwX2lkGAggASgFEhYKDnN0YWdlX21hZ2ljX2lkGAkgASgFEhkKEXN0YWdl" + "X21hZ2ljX2xldmVsGAogASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BattleEnterRequest), BattleEnterRequest.Parser, new string[10] { "Seq", "GroupId", "MonsterId", "BattleDeck", "BattleMode", "MonsterHuntId", "IsContinue", "StageMagicGroupId", "StageMagicId", "StageMagicLevel" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
