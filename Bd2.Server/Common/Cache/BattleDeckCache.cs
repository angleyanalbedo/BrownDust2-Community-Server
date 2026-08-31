using System;
using Microsoft.Extensions.Caching.Memory;

namespace Bd2.Server.Common.Cache;

public class BattleDeckCache
{
	private static IMemoryCache _memoryCache = new MemoryCache(new MemoryCacheOptions());

	public static void CacheInsertAddMinutes(string key, object value, int minute)
	{
		_memoryCache.Set(key, value, new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromMinutes(minute)));
	}

	public static void CacheInsertFromMinutes(string key, object value, int minute)
	{
		_memoryCache.Set(key, value, new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromMinutes(minute)));
	}

	public static void CacheInsert(string key, object value)
	{
		_memoryCache.Set(key, value);
	}

	public static void CacheNull(string key)
	{
		_memoryCache.Remove(key);
	}

	public static object CacheValue(string key)
	{
		return _memoryCache.Get(key);
	}
}
