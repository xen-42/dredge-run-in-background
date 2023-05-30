using UnityEngine;

namespace DredgeRunInBackground
{
	public class Loader
	{
		public static void Initialize()
		{
			Application.runInBackground = true;
		}
	}
}