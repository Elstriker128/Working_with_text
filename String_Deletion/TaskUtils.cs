using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace String_Deletion
{
    internal class TaskUtils
    {
        public static void DeleteWord(string[] line, string word)
        {
            for (int i = 0; i < line.Length; i++)
            {
                line[i] = Regex.Replace(line[i], $@"(?<![A-ząčęėįšųūžĄČĘĖĮŠŲŪŽ]){word}(\?|!|\.|,|:|;|\s|)+", "");
            }
        }
    }
}
