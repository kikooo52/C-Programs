using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2.ConcatenatesTwoTextFiles
{
    class ConcatenatesTwoTextFiles
    {
        static void Main(string[] args)
        {
            StreamReader readFileCs = new StreamReader(@"..\..\ConcatenatesTwoTextFiles.cs");
            StreamReader readFileTxt = new StreamReader(@"..\..\opatropa.txt");
            StreamWriter emptyfile = new StreamWriter(@"..\..\empty.txt");
            using (readFileCs)
            {
                using (readFileTxt)
                {
                    using (emptyfile)
                    {
                        string fullFile = readFileCs.ReadToEnd()+ readFileTxt.ReadToEnd();
                        emptyfile.WriteLine(fullFile);
                    }
                }
            }
        }
    }
    }

