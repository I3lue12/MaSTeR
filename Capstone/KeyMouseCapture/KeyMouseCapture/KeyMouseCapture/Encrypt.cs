using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace KeyMouseCapture
{
	static public class Encrypt
	{
		static private string saveStateEncrypt = "~";
		static private string hash = "The_Only_Real_Key";
		//public Encrypt()
		//{
			
		//	//function send to main
		//}

		private static string EncryptSaveState(string s)
		{
			byte[] dataToEncrypt = UTF8Encoding.UTF8.GetBytes(s);
			using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
			{
				byte[] key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
				using (TripleDESCryptoServiceProvider tripDesc = new TripleDESCryptoServiceProvider())
				{
					tripDesc.Key = key;
					tripDesc.Mode = CipherMode.ECB;
					tripDesc.Padding = PaddingMode.PKCS7;
					ICryptoTransform transform = tripDesc.CreateEncryptor();
					byte[] results = transform.TransformFinalBlock(dataToEncrypt, 0, dataToEncrypt.Length);
					string text = Convert.ToBase64String(results, 0, results.Length);
					return text;
					//function send to file
				}		
			}
		}
		public static string GetEncData(List<SaveState> ss)
		{
			foreach (SaveState s in ss)
			{
				saveStateEncrypt += s.time.ToString() + ":"
													+ s.mousePosistion.X.ToString()
													+ ":"
													+ s.mousePosistion.Y.ToString()
													+ ":"
													+ s.keyBoardClick
													+ "~";
			}

			//function encrypt;
			saveStateEncrypt = EncryptSaveState(saveStateEncrypt);
			return saveStateEncrypt;
		}
	}
}
