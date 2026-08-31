using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_CharStatOption
{
	[OriginalName("NONE_STAT")]
	NoneStat,
	[OriginalName("HEALTH_VALUE")]
	HealthValue,
	[OriginalName("HEALTH_PERCENT")]
	HealthPercent,
	[OriginalName("ATTACK_VALUE")]
	AttackValue,
	[OriginalName("ATTACK_PERCENT")]
	AttackPercent,
	[OriginalName("MAGIC_VALUE")]
	MagicValue,
	[OriginalName("MAGIC_PERCENT")]
	MagicPercent,
	[OriginalName("DEFENCE_PERCENT")]
	DefencePercent,
	[OriginalName("MAGIC_RESISTANCE_PERCENT")]
	MagicResistancePercent,
	[OriginalName("CRITICAL_CHANCE_PERCENT")]
	CriticalChancePercent,
	[OriginalName("CRITICAL_DAMAGE_PERCENT")]
	CriticalDamagePercent,
	[OriginalName("WATER_DAMAGE")]
	WaterDamage,
	[OriginalName("FIRE_DAMAGE")]
	FireDamage,
	[OriginalName("WIND_DAMAGE")]
	WindDamage,
	[OriginalName("LIGHT_DAMAGE")]
	LightDamage,
	[OriginalName("DARK_DAMAGE")]
	DarkDamage,
	[OriginalName("WATER_RESISTANCE")]
	WaterResistance,
	[OriginalName("FIRE_RESISTANCE")]
	FireResistance,
	[OriginalName("WIND_RESISTANCE")]
	WindResistance
}
