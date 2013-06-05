using System;

class Devide5And7
{
    static void Main(string[] args)
    {

        int number = int.Parse(Console.ReadLine());
        if (number % 5 == 0 && number % 7 == 0)       // 9 % 5 = 1 == 0 false; 9 % 7 =1 == 0 false ; (false)
        {
            Console.WriteLine(true);

        }
        else
        {
            Console.WriteLine(false);
            
        }
      
        
    }

}

