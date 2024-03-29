﻿using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using XLua;

namespace Common
{
	/// <summary>
	/// DESEncrypt加密解密算法。
	/// </summary>
    /// 
    [LuaCallCSharp]
	public sealed class DESEncrypt
	{
		private DESEncrypt()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

        [LuaCallCSharp]
        public static string MyEncode(string Text, Int64 tm)
        {
            tm = tm >> 1;
            var key = string.Format("{0:X}", tm);
            return DesEncrypt(Text, key);
        }

        [LuaCallCSharp]
        public static string MyDecode(string Text, Int64 tm)
        {
            tm = tm >> 1;
            var key = string.Format("{0:X}", tm);
            return DesDecrypt(Text, key);
        }

        /// <summary>
        /// DES加密
        /// </summary>
        /// <param name="encryptString"></param>
        /// <returns></returns>
        public static string DesEncrypt(string encryptString, string key)
		{
			byte[] keyBytes = Encoding.UTF8.GetBytes(key.Substring(0, 8));
			byte[] keyIV = keyBytes;
			byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);
			DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
			MemoryStream mStream = new MemoryStream();
			CryptoStream cStream = new CryptoStream(mStream, provider.CreateEncryptor(keyBytes, keyIV), CryptoStreamMode.Write);
			cStream.Write(inputByteArray, 0, inputByteArray.Length);
			cStream.FlushFinalBlock();
			return Convert.ToBase64String(mStream.ToArray());
		}

		/// <summary>
		/// DES解密
		/// </summary>
		/// <param name="decryptString"></param>
		/// <returns></returns>
		public static string DesDecrypt(string decryptString, string key)
		{
			byte[] keyBytes = Encoding.UTF8.GetBytes(key.Substring(0, 8));
			byte[] keyIV = keyBytes;
			byte[] inputByteArray = Convert.FromBase64String(decryptString);
			DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
			MemoryStream mStream = new MemoryStream();
			CryptoStream cStream = new CryptoStream(mStream, provider.CreateDecryptor(keyBytes, keyIV), CryptoStreamMode.Write);
			cStream.Write(inputByteArray, 0, inputByteArray.Length);
			cStream.FlushFinalBlock();
			return Encoding.UTF8.GetString(mStream.ToArray());
		}
	}
}