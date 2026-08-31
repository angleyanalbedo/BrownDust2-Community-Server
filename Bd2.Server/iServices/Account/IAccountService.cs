using System.Collections.Generic;
using System.Threading.Tasks;
using Bd2.Server.Model.Dto;

namespace Bd2.Server.iServices.Account;

public interface IAccountService
{
	Dictionary<string, object> Login(AccountDto accountDto);

	Task<Dictionary<string, object>> SendMail(SendMailDto dto);
}
