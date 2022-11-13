using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Seperation_Regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CFd = "Duomenys.txt";
            string punctuation = "[\\s,.;:!?()\\-]+";
            Console.WriteLine("Sutampančių žodžių {0, 3:d}", TaskUtils.Process(CFd,
           punctuation));
        }
    }
}
