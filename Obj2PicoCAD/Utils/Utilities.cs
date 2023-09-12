
using Newtonsoft.Json;
using Obj2PicoCAD.Models;

namespace Obj2PicoCAD.Utils
{
	internal static class Utilities
	{


		public static void MaxMin(Vector3 data, ref float maxX, ref float minX, ref float maxY, 
			ref float minY, ref float maxZ, ref float minZ)
		{
			maxX = Math.Max(maxX, data.x);
			minX = Math.Min(minX, data.x);
			maxY = Math.Max(maxY, data.y);
			minY = Math.Min(minY, data.y);
			maxZ = Math.Max(maxZ, data.z);
			minZ = Math.Min(minZ, data.z);
		}

		public static List<float> En(int n, int i, float r0)
		{
			double r = r0 * Math.Sqrt(2);
			float d = ((float)i / n) * 2 * (float)Math.PI;
			d += (float)(Math.PI / 4);
			return new List<float> { (float)Math.Round((Math.Cos(d) * r + r0 + 1) * 1000) / 1000, (float)Math.Round((Math.Sin(d) * r + r0) * 1000) / 1000 };
		}

		internal static void WriteToJson(string filePath, List<RecentFile> recentFiles)
		{

			CheckFile(filePath);

			string json = JsonConvert.SerializeObject(recentFiles, Formatting.Indented);
			File.WriteAllText(filePath, json);
		}

		internal static T ReadFromJson<T>(string filePath)
		{
			CheckFile(filePath);
			string json = File.ReadAllText(filePath);

			return JsonConvert.DeserializeObject<T>(json);
		}


		public static void CheckFile(string filePath)
		{

			var directoryName = Path.GetDirectoryName(filePath);
			if (!Directory.Exists(directoryName))
			{
				Directory.CreateDirectory(directoryName);
			}

			if (!File.Exists(filePath))
			{

				File.Create(filePath);
				var empty = JsonConvert.SerializeObject(new List<RecentFile>(), Formatting.Indented);
				File.WriteAllText(filePath, empty);

			}
		}
	}
}
