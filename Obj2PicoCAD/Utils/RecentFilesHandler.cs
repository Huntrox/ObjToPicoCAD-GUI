using Obj2PicoCAD.Models;

namespace Obj2PicoCAD.Utils
{
    internal static class RecentFilesHandler
    {

        private static readonly string _path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Obj2PicoCAD\\";
        private static readonly string _fileName = "recentFiles.json";
        private static readonly string _filePath = _path + _fileName;

        public static List<RecentFile> RecentFiles { get; set; } = new List<RecentFile>();


        private const int MAX_RECENT_FILES = 10;
        public static void AddRecentFile(RecentFile recent)
        {
            RecentFiles.Add(recent);
            RecentFiles = RecentFiles.Distinct().ToList();
            RecentFiles = RecentFiles.OrderByDescending(x => x.Date).ToList();
            if (RecentFiles.Count > MAX_RECENT_FILES)
            {
                RecentFiles.RemoveAt(RecentFiles.Count - 1);
            }
            Utilities.WriteToJson(_filePath, RecentFiles);
        }

        public static void RemoveRecentFile(string path)
        {
            RecentFiles.RemoveAll(x => x.Path == path);
            Utilities.WriteToJson(_filePath, RecentFiles);
        }

        public static void LoadRecentFiles()
        {
            RecentFiles = Utilities.ReadFromJson<List<RecentFile>>(_filePath) ?? new List<RecentFile>();
        }

        public static void ClearRecentFiles()
        {
            RecentFiles.Clear();
            Utilities.WriteToJson(_filePath, RecentFiles);
        }
    }
}
