using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool myGuest = true;
            int line = 100;
            int halfnum = 0;
            int andonenum = 0;
            string own = "t";
            string rettt = "da";
            while (myGuest)
            {
                andonenum = (line + halfnum) / 2;
                Console.WriteLine("My answer is {0}:", andonenum);
                string answer = Console.ReadLine();
                if (own == answer)
                {
                    Console.WriteLine("its right answer");
                    break;
                }
                    Console.WriteLine("more smoler is {0}", andonenum);
                    string ask = Console.ReadLine();
                    if (rettt == ask)
                    {
                        line = andonenum;
                        
                    }
                   else
                   {
                       halfnum = andonenum;
                   }
            }
        }
    }
}
