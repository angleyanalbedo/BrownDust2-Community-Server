using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Bd2.Server.Config;

public static class AutoMapperConfig
{
	public static IServiceCollection AddAutoMapperConfig(this IServiceCollection services)
	{
		services.AddAutoMapper(cfg =>
		{
			cfg.AddProfile(new CustomProfile());
		});
		return services;
	}
}
