using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Replay
{
	public class Decrypt
	{


		
		Decrypt()
		{

		}
		protected static string runDecryption(string EncText)
		{
			string hash = "The_Only_Real_Key";


			byte[] data = Convert.FromBase64String(EncText);
			//return data.ToString();
			using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
			{
				byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
				using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
				{
					ICryptoTransform transform = tripDes.CreateDecryptor();
					byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
					return UTF8Encoding.UTF8.GetString(result);
				}
			}
			//return "";
		}
		public static string Run(string encData)
		{
			return runDecryption(encData);
		}
	}
	
}
