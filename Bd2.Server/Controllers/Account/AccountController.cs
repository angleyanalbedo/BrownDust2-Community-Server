using System.Collections.Generic;
using System.Threading.Tasks;
using Bd2.Server.iServices.Account;
using Bd2.Server.Model.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bd2.Server.Controllers.Account;

[ApiController]
[Route("[controller]/[Action]")]
public class AccountController : ControllerBase
{
	private readonly ILogger<AccountController> _logger;

	private readonly IAccountService _accountService;

	public AccountController(ILogger<AccountController> logger, IAccountService accountService)
	{
		_logger = logger;
		_accountService = accountService;
	}

	[HttpPost]
	public Dictionary<string, object> Login([FromBody] AccountDto accountDto)
	{
		return _accountService.Login(accountDto);
	}

	[HttpPost]
	public async Task<Dictionary<string, object>> SendMail([FromBody] SendMailDto dto)
	{
		return await _accountService.SendMail(dto);
	}
}
