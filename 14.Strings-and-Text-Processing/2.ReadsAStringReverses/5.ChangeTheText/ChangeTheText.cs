using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ChangeTheText
{
    class ChangeTheText
    {
        static void Main(string[] args)
        {
            StringBuilder strigforappend = new StringBuilder();
            string someText =
                "On Monday morning,<upcase> a collective America will have</upcase> a terrible hangover from the SupeR Bowl";
            string tagString = "<upcase>";
            string tagStringnew = "</upcase>";
            int counter = 0;
            int index = -1;
            index = someText.IndexOf(tagString, index + 1);
            int newIndex = -1;
            newIndex = someText.IndexOf(tagStringnew, newIndex + 1);

            for (int i = index + 8; i < newIndex; i++)
            {
                char newchar = someText[i];
                strigforappend.Append(newchar);
                strigforappend.ToString();
            }
            string smallText = strigforappend.ToString();
            string bigText = smallText.ToUpper();
            someText = someText.Replace(tagString + smallText + tagStringnew, bigText);
            Console.WriteLine(someText);

        }
    }
}

