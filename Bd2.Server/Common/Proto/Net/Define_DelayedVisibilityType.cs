using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_DelayedVisibilityType
{
	[OriginalName("DBT_None")]
	DbtNone,
	[OriginalName("CharacterPictorialBookTable")]
	CharacterPictorialBookTable,
	[OriginalName("CostumePictorialBookTable")]
	CostumePictorialBookTable,
	[OriginalName("EquipmentPictorialBookTable")]
	EquipmentPictorialBookTable,
	[OriginalName("TalentPictorialBookTable")]
	TalentPictorialBookTable,
	[OriginalName("CostumeDesignTable")]
	CostumeDesignTable,
	[OriginalName("MercenaryScoutTable")]
	MercenaryScoutTable
}
