using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bd2.Server.Common.Utils;

public static class OfficialDns
{
	private static readonly IPAddress[] FallbackIps =
	{
		IPAddress.Parse("57.182.202.109"),
		IPAddress.Parse("13.196.107.81")
	};

	private static readonly HttpClient Http = new(new HttpClientHandler
	{
		ServerCertificateCustomValidationCallback = (_, _, _, _) => true
	});

	public static HttpClient Client => Http;

	public static async Task<IPAddress> ResolveAsync(string host)
	{
		try
		{
			var entries = await Dns.GetHostAddressesAsync(host);
			var real = entries.FirstOrDefault(ip => !IPAddress.IsLoopback(ip));
			if (real != null) return real;
		}
		catch { }
		return FallbackIps[0];
	}

	public static async Task<HttpResponseMessage> GetAsync(string url)
	{
		var uri = new Uri(url);
		var ip = await ResolveAsync(uri.Host);
		var req = new HttpRequestMessage(HttpMethod.Get, $"https://{ip}{uri.PathAndQuery}");
		req.Headers.Host = uri.Host;
		return await Http.SendAsync(req);
	}

	public static async Task<HttpResponseMessage> SendAsync(HttpRequestMessage msg)
	{
		var uri = msg.RequestUri;
		var ip = await ResolveAsync(uri.Host);
		msg.RequestUri = new Uri($"https://{ip}{uri.PathAndQuery}");
		msg.Headers.Host = uri.Host;
		return await Http.SendAsync(msg);
	}
}