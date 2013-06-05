using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.FindsSubstringIsContained
{
    class FindsSubstringIsContained
    {
        static void Main(string[] args)
        {
            string text =
                "On Monday morning, a collective America will have a terrible hangover from the SupeR Bowl";
            string newtext = text.ToLower();
            string sameText = "er";
            int counter = 0;
            int index = -1;
            while (true)
            {
                index = newtext.IndexOf(sameText, index + 1);
                if (index == -1)
                {
                    break;
                }
                counter++;
            }
            Console.WriteLine("The result is:" + counter);
        }
    }
}
