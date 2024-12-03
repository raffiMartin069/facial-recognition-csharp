using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facial_recognition.FormIdentity
{
	public static class Session
	{
		private static Dictionary<string, object> Claims = new Dictionary<string, object>();

		public static void SetClaim(string key, object value)
		{
			Claims.Add(key, value);
		}

		public static object GetClaim(string key)
		{
			return Claims[key];
		}

		public static void Clear()
		{
			Claims.Clear();
		}
	}
}
