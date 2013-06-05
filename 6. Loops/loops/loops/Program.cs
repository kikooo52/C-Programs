using System;



    class Program
    {
        static void Main(string[] args)
        {
            // Proizvedenie v interval [m-n]
            Console.Write("f =");
            int f = int.Parse(Console.ReadLine());
            Console.Write("g =");
            int g = int.Parse(Console.ReadLine());

            long praduct = 1;
            do
            {
                praduct *= f;
                f++;
            }
            while (f <= g);
            Console.WriteLine("praduct [f..g] = " + praduct);

            Console.WriteLine("n =");
            int t = int.Parse(Console.ReadLine());
            int fact = 1;
            do
            {
                fact *= t;
                t--;
            }
            while (t > 0);
            Console.WriteLine("n! = " + fact);


            // Fakturiel
            int b = int.Parse(Console.ReadLine());
            decimal factorial = 1;
            while (true)
            {
                if (b <= 1)
                {
                    break;
                }
                factorial *= b;
                b--;
            }
            Console.WriteLine(" n! =" + factorial);

            Console.WriteLine(Math.Sqrt(53));
            // Prosto chislo
            Console.Write("Enter the positive number: ");
            int bum = int.Parse(Console.ReadLine());
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(bum);
            bool prime = true;
            while (prime && (divider <= maxDivider))
            {
                if (bum % divider == 0)
                {
                    prime = false;

                }
                divider++;
            }
            Console.WriteLine("prime: ?" + prime);

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            int sum = 1;
            Console.Write("the sum 1");
            while (num < n)
            {
                num++;
                sum += num;
                Console.Write(" + " + num);
            }
            Console.WriteLine(" = " + sum);

            int counter = 0;

            while (counter <= 9)
            {
                Console.WriteLine("Number :" + counter);
                counter++;
            }
        }   
    }

