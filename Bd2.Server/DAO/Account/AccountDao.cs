using SqlSugar;

namespace Bd2.Server.DAO.Account;

[SugarTable("Account")]
public class AccountDao
{
	[SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
	public int Uid { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public int Role { get; set; }
}
