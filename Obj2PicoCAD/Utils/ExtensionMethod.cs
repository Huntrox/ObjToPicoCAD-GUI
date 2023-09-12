namespace Obj2PicoCAD.Utils
{
	internal static class ExtensionMethod
	{
		#region IsNullOrEmpty
		public static bool IsNullOrEmpty<T>(this T[] array) => array == null || array.Length < 1;
		public static bool IsNullOrEmpty<T>(this IEnumerable<T> array) => array == null || !array.Any();
		public static bool IsNullOrEmpty<T>(this List<T> list) => list == null || list.Count < 1;
		public static bool IsNullOrEmpty<T>(this Queue<T> queue) => queue == null || queue.Count < 1;
		public static bool IsNullOrEmpty<T1, T2>(this Dictionary<T1, T2> dictionary) =>
			dictionary == null || dictionary.Count < 1;
		//IList is null of empty
		public static bool IsNullOrEmpty<T>(this IList<T> list) => list == null || list.Count < 1;
		public static bool IsNullOrEmpty<T>(this ICollection<T> collection) => collection == null || collection.Count < 1;
		#endregion
	}
}
