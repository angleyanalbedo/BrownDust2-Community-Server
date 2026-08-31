using System.Collections.Generic;
using System.Threading.Tasks;
using Bd2.Server.Model.Dto;

namespace Bd2.Server.iServices.Account;

public interface IAdminService
{
	Dictionary<string, object> AdminLogin(AdminLoginDto dto);

	Task<Dictionary<string, object>> GetPlayerList(int page, int pageSize, string keyword);

	Task<Dictionary<string, object>> GetPlayerDetail(long ownerIndex);

	Task<Dictionary<string, object>> UpdatePlayer(UpdatePlayerDto dto);

	Task<Dictionary<string, object>> UpdateChar(UpdateCharDto dto);

	Task<Dictionary<string, object>> AdminSendMail(AdminSendMailDto dto);

	Task<Dictionary<string, object>> GetServerStats();

	Task<Dictionary<string, object>> DeletePlayer(long ownerIndex);
}
