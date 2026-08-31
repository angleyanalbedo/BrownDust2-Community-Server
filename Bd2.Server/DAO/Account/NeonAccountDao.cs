using SqlSugar;

namespace Bd2.Server.DAO.Account;

[SugarTable("NeonAccount")]
public class NeonAccountDao
{
	[SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
	public int Uid { get; set; }

	public string Email { get; set; }

	[SugarColumn(IsNullable = true)]
	public string PinCode { get; set; }

	[SugarColumn(IsNullable = true)]
	public string AccessToken { get; set; }

	public long MemberId { get; set; }

	public long CreateTime { get; set; }
}