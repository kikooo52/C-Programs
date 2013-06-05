using System;
using System.Linq;
using System.Diagnostics;

namespace ComparethePerformance
{
    class Program
    {
        static void DisplayExecutionTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine("{0,19}",stopwatch.Elapsed);
        }

        static void Main()
        {

            int number = 1000000;

            Console.Write("Addition Int:");
            DisplayExecutionTime(() =>
            {
                int startValue = 2;
                for (int i = 0; i < number; i++)
                {
                    startValue += 2;
                }
            });

            Console.Write("Addition long:");
            DisplayExecutionTime(() =>
            {
                long startValue = 2;
                for (int i = 0; i < number; i++)
                {
                    startValue += 2;
                }
            });

            Console.Write("Addition float:");
            DisplayExecutionTime(() =>
            {
                float startValue = 2L;
                for (int i = 0; i < number; i++)
                {
                    startValue += 2L;
                }
            });

            Console.Write("Addition double:");
            DisplayExecutionTime(() =>
            {
                double startValue = 2F;
                for (int i = 0; i < number; i++)
                {
                    startValue += 2F;
                }
            });

            Console.Write("Addition decimal:");
            DisplayExecutionTime(() =>
            {
                decimal startValue = 2M;
                for (int i = 0; i < number; i++)
                {
                    startValue += 2M;
                }
            });
            Console.WriteLine();


            Console.Write("Subtraction int:");
            DisplayExecutionTime(() =>
            {
                int startValue = 2;
                for (int i = 0; i < number; i++)
                {
                    startValue -= 2;
                }
            });

            Console.Write("Subtraction long:");
            DisplayExecutionTime(() =>
            {
                long startValue = 2L;
                for (int i = 0; i < number; i++)
                {
                    startValue -= 2L;
                }
            });

            Console.Write("Subtraction float:");
            DisplayExecutionTime(() =>
            {
                float startValue = 2F;
                for (int i = 0; i < number; i++)
                {
                    startValue -= 2F;
                }
            });

            Console.Write("Subtraction double:");
            DisplayExecutionTime(() =>
            {
                double startValue = 2D;
                for (int i = 0; i < number; i++)
                {
                    startValue -= 2D;
                }
            });

            Console.Write("Subtraction decimal:");
            DisplayExecutionTime(() =>
            {
                decimal startValue = 2M;
                for (int i = 0; i < number; i++)
                {
                    startValue -= 2M;
                }
            });

            Console.WriteLine();
            Console.Write("Multiplication int:");
            DisplayExecutionTime(() =>
            {
                int startValue;
                for (int i = 0; i < number; i++)
                {
                    startValue = 2 * 5;
                }
            });

            Console.Write("Multiplication long:");
            DisplayExecutionTime(() =>
            {
                long startValue;
                for (int i = 0; i < number; i++)
                {
                    startValue = 2L * 5L; 
                }
            });

            Console.Write("Multiplication float:");
            DisplayExecutionTime(() =>
            {
                float startValue;
                for (int i = 0; i < number; i++)
                {
                    startValue = 2F* 5F;
                }
            });

            Console.Write("Multiplication double:");
            DisplayExecutionTime(() =>
            {
                double startValue;
                for (int i = 0; i < number; i++)
                {
                    startValue = 2D * 5D;
                }
            });

            Console.Write("Multiplication decimal:");
            DisplayExecutionTime(() =>
            {
                decimal startValue;
                for (int i = 0; i < number; i++)
                {
                    startValue = 2M * 5M;
                }
            });

            Console.WriteLine();

            Console.Write("Division int:");
            DisplayExecutionTime(() =>
            {
                int startValue;
                for (int i = 0; i < number; i++)
                {
                    startValue = 2 / 5;
                }
            });
            Console.Write("Division long:");
            DisplayExecutionTime(() =>
            {
                long startValue;
                for (int i = 0; i < number; i++)
                {
                    startValue = 2L / 5L;
                }
            });
            Console.Write("Division float:");
            DisplayExecutionTime(() =>
            {
                float startValue;
                for (int i = 0; i < number; i++)
                {
                    startValue = 2F / 5F;
                }
            });
            Console.Write("Division double:");
            DisplayExecutionTime(() =>
            {
                double startValue;
                for (int i = 0; i < number; i++)
                {
                    startValue = 2D / 5D;
                }
            });
            Console.Write("Division decimal:");
            DisplayExecutionTime(() =>
            {
                decimal startValue;
                for (int i = 0; i < number; i++)
                {
                    startValue = 2M / 5M;
                }
            });
        }
    }
}
