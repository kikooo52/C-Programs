using System;


class CalculatesTrapezoid_sArea
{
static void Main(string[] args)
{   
             int a = int.Parse(Console.ReadLine());
             int b = int.Parse(Console.ReadLine());
             int h = int.Parse(Console.ReadLine());
             Console.WriteLine("the area is: {0}", (a + b) / 2 * h);   //7+7=14/2=7*h 
        }    
}