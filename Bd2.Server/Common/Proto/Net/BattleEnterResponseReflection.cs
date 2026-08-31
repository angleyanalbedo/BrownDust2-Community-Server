using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class BattleEnterResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXNwb25zZS9CYXR0bGVFbnRlclJlc3BvbnNlLnByb3RvEglwcm90by5u" + "ZXQaG0NvbW1vbnMvTW9uc3RlckRCSW5mby5wcm90bxohQ29tbW9ucy9FdmVu" + "dFNjaGVkdWxlREJJbmZvLnByb3RvGiVDb21tb25zL1BpY3RvcmlhbEJ1ZmZT" + "dGF0REJJbmZvLnByb3RvGiNDb21tb25zL01vbnN0ZXJIdW50VXNlckRCSW5m" + "by5wcm90byKVAgoTQmF0dGxlRW50ZXJSZXNwb25zZRIuCgxtb25zdGVyX2lu" + "Zm8YASABKAsyGC5wcm90by5uZXQuTW9uc3RlckRCSW5mbxITCgtiYXR0bGVf" + "ZGVjaxgCIAEoBRI7ChNldmVudF9zY2hlZHVsZV9pbmZvGAMgASgLMh4ucHJv" + "dG8ubmV0LkV2ZW50U2NoZWR1bGVEQkluZm8SOgoOYnVmZl9zdGF0X2luZm8Y" + "BCADKAsyIi5wcm90by5uZXQuUGljdG9yaWFsQnVmZlN0YXREQkluZm8SQAoW" + "bW9uc3Rlcl9odW50X3VzZXJfaW5mbxgFIAEoCzIgLnByb3RvLm5ldC5Nb25z" + "dGVySHVudFVzZXJEQkluZm9iBnByb3RvMw=="), new FileDescriptor[4]
	{
		MonsterDBInfoReflection.Descriptor,
		EventScheduleDBInfoReflection.Descriptor,
		PictorialBuffStatDBInfoReflection.Descriptor,
		MonsterHuntUserDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BattleEnterResponse), BattleEnterResponse.Parser, new string[5] { "MonsterInfo", "BattleDeck", "EventScheduleInfo", "BuffStatInfo", "MonsterHuntUserInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
