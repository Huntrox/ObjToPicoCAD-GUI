namespace Obj2PicoCAD.Models
{
	[Serializable]
	public class Vector3
	{
		public float x;
		public float y;
		public float z;

		public Vector3()
		{
			x = y = z = 0;
		}

		public Vector3(float v1, float v2, float v3)
		{
			x = v1;
			y = v2;
			z = v3;
		}
	}
}
