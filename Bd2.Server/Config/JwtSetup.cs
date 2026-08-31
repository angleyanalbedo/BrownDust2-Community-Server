using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace Bd2.Server.Config;

public static class JwtSetup
{
	public static void AddJwtSetup(this IServiceCollection services)
	{
		services.AddAuthentication(delegate(AuthenticationOptions options)
		{
			options.DefaultAuthenticateScheme = "Bearer";
			options.DefaultChallengeScheme = "Bearer";
		}).AddJwtBearer("Bearer", delegate(JwtBearerOptions options)
		{
			options.TokenValidationParameters = new TokenValidationParameters
			{
				ValidateIssuer = true,
				ValidateAudience = true,
				ValidateLifetime = true,
				ValidateIssuerSigningKey = true,
				ValidIssuer = "blue",
				ValidAudience = "blue",
				IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("1bece8b1c0cfa6ed404d0473d920f2a8"))
			};
			options.Events = new JwtBearerEvents
			{
				OnMessageReceived = delegate(MessageReceivedContext context)
				{
					string text = context.Request.Cookies["token"];
					if (!string.IsNullOrEmpty(text))
					{
						context.Token = text;
					}
					return Task.CompletedTask;
				}
			};
		});
		services.AddAuthentication().AddCookie();
	}
}
