using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;

namespace _3.EntersFileNamePath
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter file name:");
            string file = Console.ReadLine();
            StreamReader readeer = new StreamReader("path.file",Encoding.GetEncoding("windows-1251"));
            string fileee = readeer.ReadToEnd();
            Console.WriteLine(fileee);
 
        try
        {
            ReadFile(file);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
 
    }

        static void ReadFile(string file)
    {
        string content = File.ReadAllText(file);
        Console.WriteLine(content);
    }
        }
    }

