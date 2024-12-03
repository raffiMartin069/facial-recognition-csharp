using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace facial_recognition.Utility
{
	public static class HashUtility
	{
		public static string ComputeHash(byte[] imageBytes)
		{
			using (var sha256 = SHA256.Create())
			{
				return Convert.ToBase64String(sha256.ComputeHash(imageBytes));
			}
		}
	}
}
