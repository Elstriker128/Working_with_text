﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Line_Deletion
{
    internal class InOut
    {
        public static int LongestLine(string fin, out int lenght)
        {
            int No = -1;
            using (StreamReader reader = new StreamReader(fin))
            {
                string line;
                lenght = 0;
                int lineNo = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Length > lenght)
                    {
                        lenght = line.Length;
                        No = lineNo;
                    }
                    lineNo++;
                }
            }
            return No;
        }
        public static void RemoveLine(string fin, string fout, int No, int length)
        {
            using (StreamReader reader = new StreamReader(fin, Encoding.UTF8))
            {
                string line;
                int lineNo = 0;
                using (var writer = File.CreateText(fout))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Length != length)
                        {
                            writer.WriteLine(line);
                        }
                        lineNo++;
                    }
                }
            }
        }
    }
}
