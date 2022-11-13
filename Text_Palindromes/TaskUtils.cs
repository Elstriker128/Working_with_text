using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography;

namespace Text_Palindromes
{
    internal class TaskUtils
    {
        public static int Process(string fin, string punctuation)
        {
            string[] lines = File.ReadAllLines(fin, Encoding.UTF8);
            int equal = 0;
            foreach (string line in lines)
                if (line.Length > 0)
                    equal += FirstEqualLast(line, punctuation);
            return equal;
        }
        private static int FirstEqualLast(string line, string punctuation)
        {
            string[] parts = Regex.Split(line, punctuation);
            int equal = 0;
            foreach(string word in parts)
            {
                if(word.Length > 0)
                {
                    string current = word;
                    char[] reverse = word.ToCharArray();
                    Array.Reverse(reverse);
                    string reversedText = new string(reverse);

                    if (current == reversedText)
                    {
                        equal++;
                    }
                }
            }
            return equal;
        }
    }
}
