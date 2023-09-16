using Newtonsoft.Json;
using Obj2PicoCAD.Models;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Obj2PicoCAD.Utils
{
	internal static class Utilities
	{


		[DllImport("user32.dll")]
		private static extern bool SetForegroundWindow(IntPtr Hwnd);

		[DllImport("user32.dll")]
		private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		public static void ShowInExplorer(string filePath)
		{
			IntPtr hWnd = FindWindow("CabinetWClass", Path.GetDirectoryName(filePath));
			if (hWnd != IntPtr.Zero)
			{
				SetForegroundWindow(hWnd);
			}
			else
			{
				Process.Start("explorer.exe", Path.GetDirectoryName(filePath));
			}
		}

		public static List<Color> rgbColors = new List<Color>
		{
			Color.FromArgb(0, 0, 0),        // #000000
			Color.FromArgb(29, 43, 83),     // #1D2B53
			Color.FromArgb(126, 37, 83),    // #7E2553
			Color.FromArgb(0, 135, 81),     // #008751
			Color.FromArgb(171, 82, 54),    // #AB5236
			Color.FromArgb(95, 87, 79),     // #5F574F
			Color.FromArgb(194, 195, 199),  // #C2C3C7
			Color.FromArgb(255, 241, 232),  // #FFF1E8
			Color.FromArgb(255, 0, 77),     // #FF004D
			Color.FromArgb(255, 163, 0),    // #FFA300
			Color.FromArgb(255, 236, 39),   // #FFEC27
			Color.FromArgb(0, 228, 54),     // #00E436
			Color.FromArgb(41, 173, 255),   // #29ADFF
			Color.FromArgb(131, 118, 156),  // #83769C
			Color.FromArgb(255, 119, 168),  // #FF77A8
			Color.FromArgb(255, 204, 170)   // #FFCCAA
		};


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
