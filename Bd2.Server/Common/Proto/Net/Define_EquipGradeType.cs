using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_EquipGradeType
{
	[OriginalName("NONE_GRADE")]
	NoneGrade,
	[OriginalName("EQUIP_NORMAL")]
	EquipNormal,
	[OriginalName("EQUIP_RARE")]
	EquipRare,
	[OriginalName("EQUIP_HERO")]
	EquipHero,
	[OriginalName("EQUIP_LEGEND")]
	EquipLegend
}
