using System;
using System.Threading;

class loop
{
    static void Main(string[] args)
    
    {
    checked
    {
        Console.Write("n = ");
        string NumberAsString = Console.ReadLine();
        int p = int.Parse(NumberAsString);

        int sum = 0;

        for (int i = 1; i <= p; i += 2)
        {
            if ((i % 7) == 0)
                continue;
            sum += i;
        }
        Console.WriteLine("sum = {0}", sum);


        Console.Write("n = ");
        string numberAsString = Console.ReadLine();
        int n = int.Parse(numberAsString);//// dvaiset pyti shte umnoji n na stepen m 
        Console.Write("m = ");
        numberAsString = Console.ReadLine();
        int m = int.Parse(numberAsString);

        decimal result = 1;

        for (int i = 0; i < m; i++)
        {
            result *= n;
        }

        Console.WriteLine("n^m = " + result);



        for (decimal i = 1.4m; i < 28.4m; i += 0.6m)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

        for (sbyte num = 0; ; num++)
        {
            Console.Write(num + " ");
            Thread.Sleep(10);
        }


        int y = int.Parse(Console.ReadLine());
        decimal facto = 1;
        for (int i = 1; i <= y; i++)
        {
            Console.Write("*");
            facto *= i;
            Console.Write(facto);
        }
}  
}
        //// Fakturiel
        //int b = int.Parse(Console.ReadLine());
        //decimal factorial = 1;
        //while (true)
        //{
        //    Console.Write(b);
        //    if (b <= 1)
        //    {
        //        break;
        //    }
        //    Console.Write("*");
        //    factorial *= b;
        //    b--;
        //}
        //Console.WriteLine(" n! =" + factorial);



        //// Prosto chislo
        //Console.Write("Enter the positive number: ");
        //int bum = int.Parse(Console.ReadLine());
        //int divider = 2;
        //int maxDivider = (int)Math.Sqrt(bum);
        //bool prime = true;
        //while (prime && (divider <= maxDivider))
        //{
        //    if (bum % divider == 0)
        //    {
        //       // prime = false;
        //        Console.WriteLine("Found divider : {0}*{1}={2}",divider, bum / divider, bum);

        //    }
        //    divider++;
        //}
        //Console.WriteLine("prime: ?" + prime);


        //// Proizvedenie v interval [m-n]
        //Console.Write("f =");
        //int f = int.Parse(Console.ReadLine());
        //Console.Write("g =");
        //int g = int.Parse(Console.ReadLine());
                                        
        //long praduct = 1;
        //do
        //{
        //    praduct *= f;
        //    f++;
        //}
        //while (f <= g);
        //Console.WriteLine("praduct [f..g] = " + praduct);

        //Console.WriteLine("n =");
        //int t = int.Parse(Console.ReadLine());
        //int fact = 1;
        //do
        //{
        //    fact *= t;
        //    t--;
        //}
        //while (t > 0);
        //Console.WriteLine("n! = " +fact);


       

        //Console.WriteLine(Math.Sqrt(53));
        

        //Console.Write( "n = ");
        //int n = int.Parse(Console.ReadLine());
        //int num = 1;
        //int sum = 1;
        //Console.Write("the sum 1");
        //while (num < n)
        //{
        //    num++;
        //    sum += num;
        //    Console.Write(" + " + num);
        //}
        //Console.WriteLine( " = " + sum);

        //int counter = 0;

        //while (counter <= 9)
        //{
        //    Console.WriteLine("Number :" + counter);
        //    counter ++;
        //}
    }

