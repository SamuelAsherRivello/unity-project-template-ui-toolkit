using System.Collections.Generic;
using RMC.Core.ReadMe;
using UnityEditor;

namespace RMC.TravelGuide.ReadMe
{
	public static class ReadMeMenuItems
	{
		//  Fields ----------------------------------------
		public const string PathMenuItemWindowCompanyProject = "Window/" + CompanyName + "/" + ProjectName;
		public const string CompanyName = "RMC";
		public const string ProjectName = "TravelGuide";
		public const int PriorityMenuItem_Examples = -1000;
        
		//  Fields ----------------------------------------
		
		[MenuItem( PathMenuItemWindowCompanyProject + "/" + "Open ReadMe", 
			false,
						PriorityMenuItem_Examples)]
		public static void SelectReadmes()
		{
			SelectReadmeAtIndex(0);
		}
		
		private static void SelectReadmeAtIndex(int index)
		{
			List<Core.ReadMe.ReadMe> readMes = GetAllReadMes();
			
			if (index >= 0 && index < readMes.Count)
			{
				Core.ReadMe.ReadMe readMe = readMes[index];
				ReadMeHelper.SelectObject(readMe);
				ReadMeHelper.PingObject(readMe);
			}
		}
		
		private static List<Core.ReadMe.ReadMe> GetAllReadMes()
		{
			AssetDatabase.Refresh();
			var ids = AssetDatabase.FindAssets("ReadMe t:ReadMe");
			List<Core.ReadMe.ReadMe> results = new List<Core.ReadMe.ReadMe>();

			foreach (string guid in ids)
			{
				var readmeObject = AssetDatabase.LoadMainAssetAtPath(AssetDatabase.GUIDToAssetPath(guid));
				Core.ReadMe.ReadMe readMe = (Core.ReadMe.ReadMe)readmeObject;
				results.Add(readMe);
			}
			return results; ;
		}
		

	}
}
