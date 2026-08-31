using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Bd2.Server.Common.Utils;

public static class AesUtils
{
	private static readonly byte[] Key = Encoding.UTF8.GetBytes("abcdefghijkrstuv024680wxyzlmnopq");

	private static readonly byte[] Iv = new byte[16];

	public static string AesEncrypt(string data)
	{
		byte[] inArray;
		using (Aes aes = Aes.Create())
		{
			aes.Key = Key;
			aes.IV = Iv;
			ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
			using MemoryStream memoryStream = new MemoryStream();
			using CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			using (StreamWriter streamWriter = new StreamWriter(stream))
			{
				streamWriter.Write(data);
			}
			inArray = memoryStream.ToArray();
		}
		return Convert.ToBase64String(inArray);
	}

	public static string AesDecrypt(string data)
	{
		string text = null;
		using Aes aes = Aes.Create();
		aes.Key = Key;
		aes.IV = Iv;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using MemoryStream stream = new MemoryStream(Convert.FromBase64String(data));
		using CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
		using StreamReader streamReader = new StreamReader(stream2);
		return streamReader.ReadToEnd();
	}

	public static string Sha1Hash(string input)
	{
		input += "salt_alone";
		byte[] array = SHA1.HashData(Encoding.UTF8.GetBytes(input));
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.Append(b.ToString("x2"));
		}
		return stringBuilder.ToString();
	}
}
