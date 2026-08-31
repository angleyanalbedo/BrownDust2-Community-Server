using System;

namespace Bd2.Server.iServices;

/// <summary>Opt-in marker for a read endpoint that may be invoked through /Game/BatchRequest.</summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
public sealed class BatchEndpointAttribute : Attribute
{
	public BatchEndpointAttribute(string path = null)
	{
		Path = path;
	}

	public string Path { get; }
}
