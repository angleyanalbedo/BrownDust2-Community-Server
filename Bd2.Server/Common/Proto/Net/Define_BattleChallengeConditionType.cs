using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_BattleChallengeConditionType
{
	[OriginalName("BCCT_NONE")]
	BcctNone,
	[OriginalName("BCCT_CHAR_USE")]
	BcctCharUse,
	[OriginalName("BCCT_TURN_LIMIT")]
	BcctTurnLimit,
	[OriginalName("BCCT_SPECIFIC_SURVIVAL")]
	BcctSpecificSurvival,
	[OriginalName("BCCT_ELEMENT_CHAR_USE")]
	BcctElementCharUse,
	[OriginalName("BCCT_ELEMENT_CHAR_LIMIT")]
	BcctElementCharLimit,
	[OriginalName("BCCT_SKILL_USE")]
	BcctSkillUse,
	[OriginalName("BCCT_CHAR_DIE_LIMIT")]
	BcctCharDieLimit,
	[OriginalName("BCCT_WIN")]
	BcctWin
}
