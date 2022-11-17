using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace String_Deletion
{
    internal class InOut
    {
        public static string[] Process(string fin) => File.ReadAllLines(fin, Encoding.UTF8);
        public static void Print(string[] lines, string fout)
        {
            using(StreamWriter sw = new StreamWriter(fout))
            {
                foreach(string line in lines)
                {
                    sw.WriteLine(line);
                }
            }
        }
    }
}
