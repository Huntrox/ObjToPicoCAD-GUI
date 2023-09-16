namespace Obj2PicoCAD.Models
{
	
	[Serializable]
	internal class RecentFile
    {
		public string Path { get; set; }
		public string OutputPath { get; set; }
		public string Name { get; set; }
		public float Size { get; set; }
		public float Zoom { get; set; }
		public int BackgroundColor { get; set; }
		public int AlphaColor { get; set; }
		public string Date { get; set; }
		public int MeshMode { get; set; }
		public Vector3 Pos { get; set; }
		public Vector3 Rot { get; set; }

	}
}
