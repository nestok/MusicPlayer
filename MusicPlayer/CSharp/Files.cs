using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public static class Files
    {
        public static List<string> files = new List<string>();
        public static string AppPath = AppDomain.CurrentDomain.BaseDirectory;
        public static int CurrentTrackNumber;
        public static string GetFileName(string file)
        {
            string[] tmp = file.Split('\\');
            return tmp[tmp.Length - 1];
        }
    }
}
