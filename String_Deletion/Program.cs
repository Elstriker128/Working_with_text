using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace String_Deletion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Encoding.GetEncoding(1257);
            Console.InputEncoding= Encoding.GetEncoding(1257);
            const string CFd = "Duomenys.txt";
            const string CFr = "Rezultatai.txt";            
            string[] lines = InOut.Process(CFd);
            Console.Write("Input word:");
            string word = Console.ReadLine();
            TaskUtils.DeleteWord(lines, word);
            InOut.Print(lines, CFr);
        }
    }
}
