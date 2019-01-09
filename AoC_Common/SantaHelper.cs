using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_Common
{
    public static class SantaHelper
    {
        public static string GetTextFromLocalFile(string filename)
        {
            return File.ReadAllText(Directory.GetCurrentDirectory() + "\\" + filename);
        }

        public static char[] NewlineCarriageReturn => new char[] { '\r', '\n' };
    }
}
