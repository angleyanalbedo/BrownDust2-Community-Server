using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class OverwhelmRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5SZXF1ZXN0L092ZXJ3aGVsbVJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJS" + "ChhPdmVyd2hlbG1RdWVzdFVwZGF0ZUluZm8SEAoIcXVlc3RfaWQYASABKAUS" + "DwoHcGFja19pZBgCIAEoBRITCgtxdWVzdF92YWx1ZRgDIAMoBSJmChRPdmVy" + "d2hlbG1Nb25zdGVySW5mbxIQCghncm91cF9pZBgBIAEoBRISCgptb25zdGVy" + "X2lkGAIgASgFEhMKC2JhdHRsZV9kZWNrGAMgASgFEhMKC2JhdHRsZV9tb2Rl" + "GAQgASgFIo8BChBPdmVyd2hlbG1SZXF1ZXN0EgsKA3NlcRgBIAEoBRI1Cgxt" + "b25zdGVyX2luZm8YAiADKAsyHy5wcm90by5uZXQuT3ZlcndoZWxtTW9uc3Rl" + "ckluZm8SNwoKcXVlc3RfaW5mbxgDIAMoCzIjLnByb3RvLm5ldC5PdmVyd2hl" + "bG1RdWVzdFVwZGF0ZUluZm9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[3]
	{
		new GeneratedClrTypeInfo(typeof(OverwhelmQuestUpdateInfo), OverwhelmQuestUpdateInfo.Parser, new string[3] { "QuestId", "PackId", "QuestValue" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(OverwhelmMonsterInfo), OverwhelmMonsterInfo.Parser, new string[4] { "GroupId", "MonsterId", "BattleDeck", "BattleMode" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(OverwhelmRequest), OverwhelmRequest.Parser, new string[3] { "Seq", "MonsterInfo", "QuestInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
