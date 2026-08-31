using System;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Model;
using Google.Protobuf;

namespace Bd2.Server.Common.Utils;

public static class ResultUtil
{
	public static GameActionResult CreateResult(byte[] data, int packetCode)
	{
		string text = Convert.ToBase64String(data);
		return new GameActionResult
		{
			packetCode = packetCode,
			length = text.Length,
			data = AesUtils.AesEncrypt(text)
		};
	}

	public static GameActionResult CreateResult(byte[] data, int packetCode, string notify)
	{
		string text = Convert.ToBase64String(data);
		return new GameActionResult
		{
			notify = notify,
			packetCode = packetCode,
			length = text.Length,
			data = AesUtils.AesEncrypt(text)
		};
	}

	public static GameActionResult CreateResult<T>(T data) where T : IMessage<T>, new()
	{
		string text = Convert.ToBase64String(data.ToByteArray());
		return new GameActionResult
		{
			notify = "",
			packetCode = 0,
			length = text.Length,
			data = AesUtils.AesEncrypt(text)
		};
	}

	public static GameActionResult CreateResult<T>(T data, Notify notify) where T : IMessage<T>, new()
	{
		string text = Convert.ToBase64String(data.ToByteArray());
		return new GameActionResult
		{
			notify = Convert.ToBase64String(notify.ToByteArray()),
			packetCode = 0,
			length = text.Length,
			data = AesUtils.AesEncrypt(text)
		};
	}

	public static GameActionResult CreateErrorResult()
	{
		return new GameActionResult
		{
			errorType = -15
		};
	}

	public static GameActionResult CreateErrorResult(int errorType)
	{
		return new GameActionResult
		{
			errorType = errorType
		};
	}
}
