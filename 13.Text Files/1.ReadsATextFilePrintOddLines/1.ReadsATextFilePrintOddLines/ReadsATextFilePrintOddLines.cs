using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _1.ReadsATextFilePrintOddLines
{
    class ReadsATextFilePrintOddLines
    {
        static void Main(string[] args)
        {
            string fileName = @"..\..\ReadsATextFilePrintOddLines.cs";
            Console.WriteLine("Prints odd lines:");

            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();
                    lineNumber++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}
