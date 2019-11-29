using System.IO;

namespace AoC.Common
{
    public static class SantaHelper
    {
        public static string GetTextFromLocalFile(string filename)
        {
            return File.ReadAllText(Directory.GetCurrentDirectory() + "\\" + filename);
        }

        public static char[] NewlineCarriageReturn => new[] { '\r', '\n' };
    }
}
