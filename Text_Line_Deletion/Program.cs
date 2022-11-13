using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Line_Deletion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CFd = "Duomenys.txt";
            const string CFr = "Rezultatai.txt";
            int No = InOut.LongestLine(CFd, out int lenght);
            InOut.RemoveLine(CFd, CFr, No, lenght);
            Console.WriteLine("Ilgiausios eilutės nr. {0, 1:d}", No + 1);
        }
    }
}
