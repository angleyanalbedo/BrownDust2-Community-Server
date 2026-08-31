using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_ResourceType
{
	[OriginalName("RT_NORMAL")]
	RtNormal,
	[OriginalName("RT_CHAR_LEVEL_UP_MATERIAL")]
	RtCharLevelUpMaterial,
	[OriginalName("RT_COSTUME_BOOK")]
	RtCostumeBook,
	[OriginalName("RT_EQUIPMENT_MATERIAL")]
	RtEquipmentMaterial,
	[OriginalName("RT_ALCHEMY_MATERIAL")]
	RtAlchemyMaterial,
	[OriginalName("RT_CURRENCY_RESOURCE")]
	RtCurrencyResource,
	[OriginalName("RT_SELECT_COSTUME")]
	RtSelectCostume
}
