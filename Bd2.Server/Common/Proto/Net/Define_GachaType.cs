using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_GachaType
{
	[OriginalName("GT_UNION")]
	GtUnion,
	[OriginalName("GT_COSTUME")]
	GtCostume,
	[OriginalName("GT_EQUIP")]
	GtEquip
}
