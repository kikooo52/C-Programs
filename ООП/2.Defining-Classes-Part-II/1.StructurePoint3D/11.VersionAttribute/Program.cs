using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _11.VersionAttribute
{    [Version(12,2)]
    class Program
    {

    [Version(122, 32)]
    public enum someMothod { }
        static void Main(string[] args)
        {
            Type type = typeof(Program);
            object[] attributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute item in attributes)
            {
                Console.WriteLine("{0}"+item);
            }
            Type newType = typeof(someMothod);
            object[] newAttribute = newType.GetCustomAttributes(false);
            foreach (VersionAttribute item in newAttribute)
            {
                Console.WriteLine("{0}" + item);
            }
     
            
        }
    }
}
