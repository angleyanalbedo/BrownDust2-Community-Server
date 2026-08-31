using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_UserContentsInfoOptionType
{
	[OriginalName("OPTION_NONE")]
	OptionNone,
	[OriginalName("OPTION_PVP")]
	OptionPvp,
	[OriginalName("OPTION_EVILCASTLE")]
	OptionEvilcastle,
	[OriginalName("OPTION_MONSTER_HUNT")]
	OptionMonsterHunt,
	[OriginalName("OPTION_TOTAL_WAR")]
	OptionTotalWar,
	[OriginalName("OPTION_TOTAL_BATTLE_POWER")]
	OptionTotalBattlePower
}
