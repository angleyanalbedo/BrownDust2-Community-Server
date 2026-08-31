using System.Collections.Generic;

namespace Bd2.Server.Common.DB;

public class MutiDBOperate
{
	public bool Enabled { get; set; }

	public string ConnId { get; set; }

	public int HitRate { get; set; }

	public string Connection { get; set; }

	public DataBaseType DbType { get; set; }

	public List<MutiDBOperate> Slaves { get; set; }
}
