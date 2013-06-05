using System;
using System.Threading;
using System.Globalization;

    class QuadraticEquation
    {
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
        DateTime t = new DateTime(2018, 2, 4, 9, 13, 25);
        Console.WriteLine("{0:D}", t);

        Console.Write("ime:");
        string ime = Console.ReadLine();
        Console.Write("Fmileq:");
        string famileq = Console.Read();

        Console.WriteLine("Hello {0} {1}",ime, famileq );


        //Console.WriteLine("{0:G}", DayOfWeek.Monday);
        //Console.WriteLine("{0:D}", DayOfWeek.Monday);
        //Console.WriteLine("{0:X}", DayOfWeek.Monday);
        //DateTime d = new DateTime(2018, 23, 4, 9, 13, 45);
        //Console.WriteLine("{0:dd/MM/yyyy HH:mm:ss}", d);

        //Console.WriteLine("{0,4}",123);
        //Console.WriteLine("{0,5}", 12323);
        //Console.WriteLine("{0,1}", -7621231233);
        //Console.WriteLine("{0:C4}", 123.456777);
        //Console.WriteLine("{0}{3}{2}{1}",12, "wer",33, "sdf" );
        //string s ="four:" +(2+2);
        //Console.WriteLine(s);
        //int g = 32;
        //string age = " 123 ";
        //Console.WriteLine(123123 + age + g + "asg");
        //string r = "da213";
        //Console.WriteLine(r);
        //Console.ReadLine();
        //Console.Write("Enter a:");
        //int a = int.Parse(Console.ReadLine());
        //Console.Write("Enter b  :");
        //int b = int.Parse(Console.ReadLine());
        //Console.Write("Enter c:");
        //int c = int.Parse(Console.ReadLine());
        //double x1, x2;
        //double D = (b * b) - 4 * (a * c);
        //if (D < 0 )
        //{
        //    Console.WriteLine("have wrong roots");
        //}
        //else
        //    {
        //        if (D == 0)
        //        {
        //            x1 = (-b) / (2 * a);
        //            Console.WriteLine("Uravnenieto ima edin dvoen koren x1:{0}", x1);
        //        }

        //        else
        //        {
        //            x1 = ((-b) + Math.Sqrt(D)) / (2 * a);
        //            x2 = ((-b) - Math.Sqrt(D)) / (2 * a);
        //            Console.WriteLine("the root \"x1\":{0} \"x2\":{1}", x1, x2);
        //        }
        //    }
           

            

    }
}

