using System;
using UnityEngine;

namespace Microlite78
{
	public static class Util
	{
		public static void LogException(Exception e) {
			Debug.Log (String.Format ("{0}\n{1}", e.Message, e.StackTrace));
		}
	}
}

