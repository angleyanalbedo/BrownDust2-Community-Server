using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_TalentSkillType
{
	[OriginalName("TS_NONE")]
	TsNone,
	[OriginalName("TS_STEAL")]
	TsSteal,
	[OriginalName("TS_FAST_DASH")]
	TsFastDash,
	[OriginalName("TS_OVERWHELM")]
	TsOverwhelm,
	[OriginalName("TS_ABSORPTION")]
	TsAbsorption,
	[OriginalName("TS_INTERROGATE")]
	TsInterrogate,
	[OriginalName("TS_EXAMINE")]
	TsExamine,
	[OriginalName("TS_COOKING")]
	TsCooking,
	[OriginalName("TS_ALCHEMY")]
	TsAlchemy,
	[OriginalName("TS_EQUIPMENT_MAKING")]
	TsEquipmentMaking,
	[OriginalName("TS_CHAR_CURE")]
	TsCharCure,
	[OriginalName("TS_SPELL_CONTROL")]
	TsSpellControl,
	[OriginalName("TS_TRAP_SEARCH")]
	TsTrapSearch,
	[OriginalName("TS_MOVE_SPEED_UP")]
	TsMoveSpeedUp,
	[OriginalName("TS_CHAR_IMMORTAL")]
	TsCharImmortal,
	[OriginalName("TS_CREATE_WAY_POINT")]
	TsCreateWayPoint,
	[OriginalName("TS_SHOP_DISCOUNT")]
	TsShopDiscount,
	[OriginalName("TS_STEALTH")]
	TsStealth,
	[OriginalName("TS_DISPATCH")]
	TsDispatch,
	[OriginalName("TS_CHARM_BY_NPC")]
	TsCharmByNpc,
	[OriginalName("TS_SUMMON")]
	TsSummon
}
