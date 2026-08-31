using System;
using Google.Protobuf;

namespace Bd2.Server.Common.Utils;

public static class ProtoUtil
{
	public static T Deserialize<T>(string data) where T : IMessage<T>, new()
	{
		try
		{
			if (string.IsNullOrWhiteSpace(data))
				throw new ArgumentException("请求数据为空", nameof(data));

			string s = AesUtils.AesDecrypt(data);
			return new MessageParser<T>(() => new T()).ParseFrom(Convert.FromBase64String(s));
		}
		catch (Exception ex)
		{
			// 不记录完整请求内容，避免把令牌或用户数据写入日志。
			Console.Error.WriteLine(
				$"[ProtoUtil] Deserialize<{typeof(T).Name}> failed: {ex.GetType().Name}: {ex.Message}");
			return new T();
		}
	}
}
