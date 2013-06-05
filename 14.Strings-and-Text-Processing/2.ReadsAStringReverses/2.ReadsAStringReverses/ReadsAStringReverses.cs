using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ReadsAStringReverses
{
    class ReadsAStringReverses
    {
        static void Main(string[] args)
        {
            string word = "Elate da Peem";
            for (int i = word.Length-1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }
            Console.WriteLine();
        }
    }
}
