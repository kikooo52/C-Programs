using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string someText = "alabalanica";
            StringBuilder someString = new StringBuilder(someText);
           
            Console.WriteLine(someString.SubString(1,7).ToString());
        }
    }
}
