using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4.ComparesTwoTextFilesLineByLine
{
    class ComparesTwoTextFilesLineByLine
    {
        static void Main(string[] args)
        {

            StreamReader fileNameOfCs = new StreamReader(@"..\..\ComparesTwoTextFilesLineByLine.cs");
            StreamReader fileNameOfTxt = new StreamReader(@"..\..\text.txt");
            using (fileNameOfTxt)
            {
                using (fileNameOfCs)
                {
                    int lineDifferent = 0, LineEqual = 0;

                    string lineCs;  
                    string lineTxt;  
                    while ((lineCs = fileNameOfCs.ReadLine()) != null && (lineTxt = fileNameOfTxt.ReadLine()) != null)
                    {
                        if (lineCs == lineTxt)
                        {
                            LineEqual++;
                        }
                        else
                        {
                            lineDifferent++;
                        }
                    }
                    Console.WriteLine("Equals are:{0}, and differents are {1} ",LineEqual, lineDifferent);
                }
            }
        }
    }
}
