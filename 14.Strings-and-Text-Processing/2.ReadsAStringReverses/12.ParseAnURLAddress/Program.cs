//Write a program that parses an URL address given in the format: and extracts from it the [protocol],

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _12.ParseAnURLAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://victory.bg/index.php/home/category/about/";
            int indexOfUlr = 0;
            indexOfUlr = url.IndexOf(':');
            Console.WriteLine("[protocol] = \"{0}\"", url.Substring(0, indexOfUlr));
            url = url.Replace(url.Substring(0, indexOfUlr + 3), "");

            indexOfUlr = url.IndexOf('/');
            Console.WriteLine("[server] = \"{0}\"", url.Substring(0, indexOfUlr));
            url = url.Replace(url.Substring(0, indexOfUlr), "");

            Console.WriteLine("[resource] = \"{0}\"", url);
 
        }
    }
}
