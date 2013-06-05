using System;
using System.Collections.Generic;


class ForEach
{
     static void Main(string[] args)
      {
         string [] day = new string[] { "Monday", "Tuesday", "Wednesday", 
            "Thursday", "Friday", "Saturday", "Sunday" };
         List<int> days = new List<int> () {131,23,123,12};
     foreach (var d in days)
	{
		 Console.WriteLine(d);
         foreach (var a in day)
	{
		 Console.WriteLine(a);
	}
	}







      }
}

