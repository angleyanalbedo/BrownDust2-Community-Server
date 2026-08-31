using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_GachaLogType
{
	[OriginalName("GACHA_LOG_COSTUME_PICK_UP")]
	GachaLogCostumePickUp,
	[OriginalName("GACHA_LOG_COSTUME")]
	GachaLogCostume,
	[OriginalName("GACHA_LOG_EQUIP_PICK_UP")]
	GachaLogEquipPickUp,
	[OriginalName("GACHA_LOG_EQUIP")]
	GachaLogEquip
}
