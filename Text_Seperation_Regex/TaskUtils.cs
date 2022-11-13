using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Text_Seperation_Regex
{
    internal class TaskUtils
    {
        public static int Process(string fin, string punctuation)
        {
            string[] lines = File.ReadAllLines(fin);
            int equal = 0;
            foreach (string line in lines)
            {
                if (line.Length > 0)
                {
                    equal += FirstEqualLast(line, punctuation);

                }
            }
            return equal;
        }
        private static int FirstEqualLast(string line, string punctuation)
        {
            string[] parts = Regex.Split(line, punctuation);
            int equal = 0;
            foreach(string word in parts)
            {
                if(word.Length>0)
                {
                    if (word[0] == word[word.Length-1] || Char.ToUpper(word[0]) == word[word.Length - 1] || 
                        Char.ToUpper(word[0]) == Char.ToUpper(word[word.Length - 1]) || word[0] == Char.ToUpper(word[word.Length - 1]))
                    {
                        equal++;
                    }
                }
            }
            return equal;
        }
    }
}
