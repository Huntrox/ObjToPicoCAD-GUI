using Obj2PicoCAD.Utils;

namespace Obj2PicoCAD.Models
{
	internal class ObjReader
    {

		public Vector3 Pos { get; set; } =  new Vector3(0, 0, 0);
		public Vector3 Rot { get; set; } = new Vector3(0, 0, 0);

		public int AlphaColorIndex { get; set; } = 0;
		public int BgColorIndex { get; set; } = 0;
		public float Zoom { get; set; } = 16;
		
		private int _meshMode = 10;
		
				
		public void ObjToPicoCAD(string path,string exportPath,float size0,int meshMode)
		{
			float maxX = -20000, minX = 20000, maxY = -20000, minY = 20000, maxZ = -20000, minZ = 20000;

			var v = new List<Vector3>();
			var f = new List<List<int>>();


			_meshMode = meshMode;

			StreamReader sr = null;
			try
			{
				sr = new StreamReader(path);
			}
			catch (IOException)
			{
				Console.WriteLine("File read error");
				Console.WriteLine("Press any key to exit...");
				Console.ReadKey();
				return;
			}

			ReadObj(sr, v, f, ref maxX, ref minX, ref maxY, ref minY, ref maxZ, ref minZ);
			sr.Close();
			
			var size = size0 / Math.Max(Math.Max(Math.Abs(maxX - minX), Math.Abs(maxY - minY)), Math.Abs(maxZ - minZ));


			WriteToTxt(exportPath, size, v, f);




		}

		private void ReadObj(StreamReader sr, List<Vector3> v, List<List<int>> f, ref float maxX, ref float minX, ref float maxY,
			ref float minY, ref float maxZ, ref float minZ)
		{
			while (sr.Peek() >= 0)
			{
				var line = sr.ReadLine() ?? string.Empty;
				float v1, v2, v3;

				if (line.StartsWith("v "))
				{
					string[] parts = line.Split(' ');
					if (parts.Length >= 4)
					{
						if (float.TryParse(parts[1], out v1) && float.TryParse(parts[2], out v2) && float.TryParse(parts[3], out v3))
						{
							v.Add(new Vector3(v1, v2, v3));
							Utilities.MaxMin(new Vector3(v1, v2, v3), ref maxX, ref minX, ref maxY, ref minY, ref maxZ, ref minZ);
						}
					}
				}
				else if (line.StartsWith("f "))
				{
					var parts = line.Split(' ');
					var f0 = new List<int>();
					for (int i = 0; i < parts.Length; i++)
					{

						var components = parts[i].Split('/');

						if (components.Length >= 1)
						{
							int index;
							if (int.TryParse(components[0], out index))
							{
								f0.Add(index);
							}
						}


					}
					f.Add(f0);
				}
			}
		}
		
		private void WriteToTxt(string exportFilePath,float size, List<Vector3> v, List<List<int>> f)
		{
			
			var filename = Path.GetFileNameWithoutExtension(exportFilePath);


			if (!exportFilePath.EndsWith(".txt"))
				exportFilePath = exportFilePath + ".txt";
			StreamWriter outputfile = new StreamWriter(exportFilePath);

			var header = $"picocad;{filename};{Zoom};{BgColorIndex};{AlphaColorIndex}\n";
			var fileSettings = $"{{\n{{\n name='{filename}',pos={{{Pos.x},{Pos.y},{Pos.z}}},rot={{{Rot.x},{Rot.y},{Rot.z}}},\n";

			
			outputfile.WriteLine(header + fileSettings);
			outputfile.WriteLine(" v={");


			for (int i = 0; i < v.Count; i++)
			{
				outputfile.Write("  {" + v[i].x * size + "," + v[i].y * size + "," + v[i].z * size + "}");
				if (i + 1 != v.Count) outputfile.WriteLine(",");
				else outputfile.WriteLine();
			}
			outputfile.WriteLine(" },\n");

			//----f------
			outputfile.WriteLine(" f={");
			for (int i = 0; i < f.Count; i++)
			{
				outputfile.Write("  {");
				for (int j = 0; j < f[i].Count; j++)
				{
					if (_meshMode == 0)
					{
						outputfile.Write(f[i][j] + ",");
					}
					else
					{
						outputfile.Write(f[i][f[i].Count - j - 1] + ",");
					}
				}
				outputfile.Write(" c=10, uv={");
				for (int j = 0; j < f[i].Count; j++)
				{
					List<float> d = Utilities.En(f[i].Count, j, 1);
					outputfile.Write(d[0] + "," + d[1]);
					if (j + 1 != f[i].Count) outputfile.Write(",");
					else outputfile.Write("} }");
				}
				if (i + 1 != f.Count) outputfile.WriteLine(",");
				else outputfile.WriteLine();
			}

			outputfile.Write("}\n}\n}%\n00000000eeee8888eeee8888aaaa9999aaaa9999bbbb3333bbbb3333ccccddddccccddddffffeeeeffffeeee7777666677776666555566665555666600000000\n00000000eeee8888eeee8888aaaa9999aaaa9999bbbb3333bbbb3333ccccddddccccddddffffeeeeffffeeee7777666677776666555566665555666600000000\n00000000eeee8888eeee8888aaaa9999aaaa9999bbbb3333bbbb3333ccccddddccccddddffffeeeeffffeeee7777666677776666555566665555666600000000\n00000000eeee8888eeee8888aaaa9999aaaa9999bbbb3333bbbb3333ccccddddccccddddffffeeeeffffeeee7777666677776666555566665555666600000000\n000000008888eeee8888eeee9999aaaa9999aaaa3333bbbb3333bbbbddddccccddddcccceeeeffffeeeeffff6666777766667777666655556666555500000000\n000000008888eeee8888eeee9999aaaa9999aaaa3333bbbb3333bbbbddddccccddddcccceeeeffffeeeeffff6666777766667777666655556666555500000000\n000000008888eeee8888eeee9999aaaa9999aaaa3333bbbb3333bbbbddddccccddddcccceeeeffffeeeeffff6666777766667777666655556666555500000000\n000000008888eeee8888eeee9999aaaa9999aaaa3333bbbb3333bbbbddddccccddddcccceeeeffffeeeeffff6666777766667777666655556666555500000000\n00000000eeee8888eeee8888aaaa9999aaaa9999bbbb3333bbbb3333ccccddddccccddddffffeeeeffffeeee7777666677776666555566665555666600000000\n00000000eeee8888eeee8888aaaa9999aaaa9999bbbb3333bbbb3333ccccddddccccddddffffeeeeffffeeee7777666677776666555566665555666600000000\n00000000eeee8888eeee8888aaaa9999aaaa9999bbbb3333bbbb3333ccccddddccccddddffffeeeeffffeeee7777666677776666555566665555666600000000\n00000000eeee8888eeee8888aaaa9999aaaa9999bbbb3333bbbb3333ccccddddccccddddffffeeeeffffeeee7777666677776666555566665555666600000000\n000000008888eeee8888eeee9999aaaa9999aaaa3333bbbb3333bbbbddddccccddddcccceeeeffffeeeeffff6666777766667777666655556666555500000000\n000000008888eeee8888eeee9999aaaa9999aaaa3333bbbb3333bbbbddddccccddddcccceeeeffffeeeeffff6666777766667777666655556666555500000000\n000000008888eeee8888eeee9999aaaa9999aaaa3333bbbb3333bbbbddddccccddddcccceeeeffffeeeeffff6666777766667777666655556666555500000000\n000000008888eeee8888eeee9999aaaa9999aaaa3333bbbb3333bbbbddddccccddddcccceeeeffffeeeeffff6666777766667777666655556666555500000000\n");
			
			outputfile.Close();
		}
	}
}
