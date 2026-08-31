using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Hosting;
using SqlSugar;

namespace Bd2.Server.Config;

public sealed class EquipmentOptionService : IHostedService
{
	private readonly ISqlSugarClient _db;

	private readonly IMapper _mapper;

	public EquipmentOptionService(ISqlSugarClient db, IMapper mapper)
	{
		_db = db;
		_mapper = mapper;
	}

	public Task StartAsync(CancellationToken cancellationToken)
	{
		return Task.CompletedTask;
	}

	public Task StopAsync(CancellationToken cancellationToken)
	{
		return Task.CompletedTask;
	}
}
