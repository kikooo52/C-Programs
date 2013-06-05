using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _3.ReadsATextFileAndInsertLine
{
    class ReadsATextFileAndInsertLine
    {
        static void Main(string[] args)
        {
            StreamWriter emptyFile = new StreamWriter(@"..\..\empty.txt");
            StreamReader readerFile = new StreamReader(@"..\..\ReadsATextFileAndInsertLine.cs");
            using (emptyFile)
            {
                using (readerFile)
                {
                    string lineOfFile;
                    int lineNumber = 0;
                    while ((lineOfFile = readerFile.ReadLine()) != null)
                    {
                        emptyFile.WriteLine(++lineNumber + " " + lineOfFile);
                    }
                }
            }
        }
    }
}


