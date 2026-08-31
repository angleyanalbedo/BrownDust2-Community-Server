using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Bd2.Server.iServices;
using Bd2.Server.Model;
using Microsoft.Extensions.DependencyInjection;

namespace Bd2.Server.Services.Game;

public class BatchService : IBatchService
{
	private readonly Dictionary<string, (object Service, MethodInfo Method)> _domainEndpoints;

	public BatchService(IServiceProvider serviceProvider)
	{
		_domainEndpoints = DiscoverDomainEndpoints(serviceProvider);
	}

	public bool TryDispatch(string path, string data, string uid, out GameActionResult result)
	{
		var endpointName = path.Trim('/');
		if (!_domainEndpoints.TryGetValue(endpointName, out var endpoint))
		{
			result = null;
			return false;
		}

		result = (GameActionResult)endpoint.Method.Invoke(endpoint.Service, new object[] { data, uid });
		return true;
	}

	private static Dictionary<string, (object Service, MethodInfo Method)> DiscoverDomainEndpoints(IServiceProvider serviceProvider)
	{
		var endpoints = new Dictionary<string, (object Service, MethodInfo Method)>(StringComparer.Ordinal);
		var serviceTypes = Assembly.GetExecutingAssembly().GetTypes()
			.Where(type => type.IsClass && !type.IsAbstract && typeof(IBatchEndpointService).IsAssignableFrom(type));

		foreach (var serviceType in serviceTypes)
		{
			var interfaceType = serviceType.GetInterfaces().FirstOrDefault(type => type.Name == "I" + serviceType.Name);
			var service = interfaceType == null ? null : serviceProvider.GetService(interfaceType);
			if (service == null) continue;

			foreach (var method in serviceType.GetMethods(BindingFlags.Instance | BindingFlags.Public))
			{
				var attribute = method.GetCustomAttribute<BatchEndpointAttribute>();
				if (attribute == null) continue;
				if (method.ReturnType != typeof(GameActionResult) || method.GetParameters().Length != 2)
					throw new InvalidOperationException($"Batch endpoint {serviceType.Name}.{method.Name} must return GameActionResult and accept (string data, string uid).");

				var endpointName = string.IsNullOrWhiteSpace(attribute.Path) ? method.Name : attribute.Path.Trim('/');
				if (!endpoints.TryAdd(endpointName, (service, method)))
					throw new InvalidOperationException($"Duplicate batch endpoint: {endpointName}");
			}
		}

		return endpoints;
	}
}
