using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.MethodThatAsksUsersName
{
    class MethodThatAsksUsersName
    {
        static void AsksTheUserName()
        {
            Console.Write("Your name is ? :");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}",name);
        }
        static void Main(string[] args)
        {
            AsksTheUserName();
        }
    }
}
