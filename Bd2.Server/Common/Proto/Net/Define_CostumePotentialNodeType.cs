using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_CostumePotentialNodeType
{
	[OriginalName("CPNT_NONE")]
	CpntNone,
	[OriginalName("CPNT_CONNECTION_POTENTIAL_STAT")]
	CpntConnectionPotentialStat,
	[OriginalName("CPNT_PUBLIC_POTENTIAL_STAT")]
	CpntPublicPotentialStat,
	[OriginalName("CPNT_BUFF_ADD_NODE")]
	CpntBuffAddNode,
	[OriginalName("CPNT_BUFF_MODIFY_NODE")]
	CpntBuffModifyNode,
	[OriginalName("CPNT_SP_DECREASE_NODE")]
	CpntSpDecreaseNode,
	[OriginalName("CPNT_COOL_DOWN_DECREASE_NODE")]
	CpntCoolDownDecreaseNode,
	[OriginalName("CPNT_ATTACK_RANGE_NODE")]
	CpntAttackRangeNode
}
