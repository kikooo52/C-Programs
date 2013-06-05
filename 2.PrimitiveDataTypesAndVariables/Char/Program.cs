using System;

class Char
{
    static void Main()
    {  
        int myInt = 5;
        Console.WriteLine(myInt);
        long myLong = myInt;
        Console.WriteLine(myLong);
        Console.WriteLine(myLong + myInt);

        double myD = 5.1d;
        Console.WriteLine(myD);

        long myL = (long)myD;
        Console.WriteLine(myL);

        myD = 5e9d;
        Console.WriteLine(myD);

        int myI = (int)myD;
        Console.WriteLine(myI);
        Console.WriteLine(int.MinValue);
        double y = 5e12d;
        Console.WriteLine(y);
        long ymlong = long.MaxValue;
        int ymInt = (int)ymlong;
        Console.WriteLine(ymlong);
        Console.WriteLine(ymInt);
        int f = 3;
        Console.WriteLine(f.ToString());
        int a = 5;
        int b = 7;
        string sum = "sum=" + (a + b);
        Console.WriteLine(sum);
        string incorrect = "sum=" + a + b;
        Console.WriteLine(incorrect);
        Console.WriteLine("perimeter=" + 2 *(a + b) +".Area =" + (a * b) +".");

        int r = (150 - 20) / 2 + 5;

        double surface = Math.PI * r * r;
        double perimeter = 2 * Math.PI * r;
        Console.WriteLine(r);
        Console.WriteLine(surface);
        Console.WriteLine(perimeter);

        int t = 5;
        int j = ++t;
        Console.WriteLine(j);
        Console.WriteLine(t);
        double d = 1 / 2;
        Console.WriteLine(d);
        double falf = (double)1 / 2;
        Console.WriteLine(falf);
        int num = 1;
        double denum = 0;
        int zeroint = (int)denum;
        Console.WriteLine(num / denum);
        Console.WriteLine(denum/denum);

        double incorrecte = (double)((1 + 2) / 4);
        Console.WriteLine(incorrecte);
        double correct = ((double)(1 + 2) / 4);
        Console.WriteLine(correct);

        Console.WriteLine("2+3 = " + 2+3);
        Console.WriteLine("2+3 = " + (2+3));
        Console.WriteLine("\n\t"+(2+3));


                  
        /*
        //aritmatics operation
        int squarePerimerer = 50;
        double squareSite = squarePerimerer / 4.0;
        double squareArea = squareSite * squareSite;
        Console.WriteLine(squareSite);
        Console.WriteLine(squareArea);
        int a = 5;
        int b = 4;
        Console.WriteLine("\t\t\n{0}",  a + b);
        Console.WriteLine(a + b++);
        Console.WriteLine(a + b);
        Console.WriteLine(a + (++b));
        Console.WriteLine(a + b);
        Console.WriteLine(14 / a);
        Console.WriteLine(14 % a);

        int one = 1;
        int zero = 0;
        /// Console.WriteLine(one / zero);

        double minusone = -1.0;
        double dzero = 0.0;
        Console.WriteLine(minusone / dzero);
        {
            bool e = true;
            bool r = false;
            Console.WriteLine(e && r);
            Console.WriteLine(e || r);
            Console.WriteLine(!r);
            Console.WriteLine(r || true);
            Console.WriteLine((5 > 7)^(e==r));

            byte t = 3;
            byte y = 5;

            Console.WriteLine("\n{0}" , t | y);
            Console.WriteLine(t & y);
            Console.WriteLine(t ^ y);
            Console.WriteLine(t << 2);
            Console.WriteLine(~t << 2);
            Console.WriteLine(t << 1);
            Console.WriteLine(y << 4 );
            Console.WriteLine(t >> 1);

            int x = 10,  z= 5;
            Console.WriteLine("\nx > z : " + (x > z));
            Console.WriteLine("x < z : " + (x < z));
            Console.WriteLine("x >= z : " + (x >= z));
            Console.WriteLine("x <= z : " + (x <= z));
            Console.WriteLine("x == z : " + (x == z));
            Console.WriteLine("x != z : " + (x != z));

            int l, p, q;
            l = p = q = 25;
            Console.WriteLine("\nl:{0}\np:{1}\nq:{2}" , l, p, q);
            int h = 8;
            Console.WriteLine(h);
            Console.WriteLine(h |= 1); //direktno izvyrshva operaciqta i prisvoqva stoinosta
            Console.WriteLine(h += 3);
              Console.WriteLine(h /= 2);


            // Usloven operator

              int v = 2, n = 4;
            Console.WriteLine(v > n ? "v > n" : "v <=n");

            bool num = (n == v) ? true : false;
            Console.WriteLine(num);

            int[] arr = { 1, 2, 3 };
            Console.WriteLine(arr[2]);
            string str = "hello";
            Console.WriteLine(str[0]);

            int con = 6;
            int magore = 3;

            Console.WriteLine(con + magore / 2);
            Console.WriteLine((con + magore) / 2);

            string s = "beer";
            Console.WriteLine(s );

            string notnull = s;
            string nullstring = null;
            Console.WriteLine(nullstring ?? "unspecifild");
            Console.WriteLine(notnull ?? "specifild");
               */


        
    }
        
}

