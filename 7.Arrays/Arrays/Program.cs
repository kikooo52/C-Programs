using System;
using System.Collections.Generic;
using System.Linq;

namespace Nakov.IO
{
    using System;
    using System.Text;
    using System.Globalization;

    /// <summary>
    /// Console input helper for C# and .NET. Allows simplified reading of numbers and string
    /// tokens from the console in a way similar to "cin" in C++ and java.util.Scanner in Java.
    /// </summary>
    /// 
    /// <copyright>
    /// (c) Svetlin Nakov, 2011 - http://www.nakov.com
    /// </copyright>
    /// 
    /// <example>
    /// // In C++ we will use "cin >> x >> y;"
    /// // Using Nakov.IO.Cin we can do the same as follows:
    /// int x = Cin.NextInt();
    /// double y = Cin.NextDouble();
    /// </example>
    /// 
    public static class Cin
    {
        /// <summary>
        /// Reads a string token from the console
        /// skipping any leading and trailing whitespace.
        /// </summary>
        public static string NextToken()
        {
            StringBuilder tokenChars = new StringBuilder();
            bool tokenFinished = false;
            bool skipWhiteSpaceMode = true;
            while (!tokenFinished)
            {
                int nextChar = Console.Read();
                if (nextChar == -1)
                {
                    // End of stream reached
                    tokenFinished = true;
                }
                else
                {
                    char ch = (char)nextChar;
                    if (char.IsWhiteSpace(ch))
                    {
                        // Whitespace reached (' ', '\r', '\n', '\t') -->
                        // skip it if it is a leading whitespace
                        // or stop reading anymore if it is trailing
                        if (!skipWhiteSpaceMode)
                        {
                            tokenFinished = true;
                            if (ch == '\r' && (Environment.NewLine == "\r\n"))
                            {
                                // Reached '\r' in Windows --> skip the next '\n'
                                Console.Read();
                            }
                        }
                    }
                    else
                    {
                        // Character reached --> append it to the output
                        skipWhiteSpaceMode = false;
                        tokenChars.Append(ch);
                    }
                }
            }
            
            string token = tokenChars.ToString();
            return token;
        }

        /// <summary>
        /// Reads an integer number from the console
        /// skipping any leading and trailing whitespace.
        /// </summary>
        public static int NextInt()
        {
            string token = Cin.NextToken();
            return int.Parse(token);
        }

        /// <summary>
        /// Reads a floating-point number from the console
        /// skipping any leading and trailing whitespace.
        /// </summary>
        /// <param name="acceptAnyDecimalSeparator">
        /// Specifies whether to accept any decimal separator
        /// ("." and ",") or the system's default separator only.
        /// </param>
        public static double NextDouble(bool acceptAnyDecimalSeparator = true)
        {
            string token = Cin.NextToken();
            if (acceptAnyDecimalSeparator)
            {
                token = token.Replace(',', '.');
                double result = double.Parse(token, CultureInfo.InvariantCulture);
                return result;
            }
            else
            {
                double result = double.Parse(token);
                return result;
            }
        }

        /// <summary>
        /// Reads a decimal number from the console
        /// skipping any leading and trailing whitespace.
        /// </summary>
        /// <param name="acceptAnyDecimalSeparator">
        /// Specifies whether to accept any decimal separator
        /// ("." and ",") or the system's default separator only.
        /// </param>
        public static decimal NextDecimal(bool acceptAnyDecimalSeparator = true)
        {
            string token = Cin.NextToken();
            if (acceptAnyDecimalSeparator)
            {
                token = token.Replace(',', '.');
                decimal result = decimal.Parse(token, CultureInfo.InvariantCulture);
                return result;
            }
            else
            {
                decimal result = decimal.Parse(token);
                return result;
            }
        }
    }
}



class Program
{
    static void Main(string[] args)
    {

        int[] arr = { 1, 423, 3, 34, 34, };
        //int[] arr2 = new int [arr.Length];
        //Array.Copy(arr, arr2, arr.Length);
        int[] arr2 = (int[])arr.Clone();
        arr[1] = -1;

        foreach (var item in arr2)
        {
            Console.WriteLine(item);
        }

        List<int> num = new List<int>();
        for (int i = 0; i < 10; i++)        {
            num.Add(i);
        }
        Console.WriteLine(num.Count());






        //string str = Console.ReadLine();
        //string[] tokens = str.Split(' ');
        //int[] array = new int[tokens.Length];
        //for (int i = 0; i < array.Length; i++)
        //{
        //    array[i] = int.Parse(tokens[i]);
        //}

        //Console.Write("Number of elements:");
        //int size = Nakov.IO.Cin.NextInt();

        //int[] array = new int[size];

        //for (int i = 0; i < size; i++)
        //{
        //    Console.Write("Arr {0} is = ", i);
        //    array[i] = Nakov.IO.Cin.NextInt();
        //}

        //          bool isSimetric = true;
        //          for (int i = 0; i < array.Length / 2; i++)
        //          {
        //              if (array[i] != array[array.Length-i-1])
        //              {
        //                  isSimetric = false;
        //                  break;
        //              }
        //          }
        //          Console.WriteLine("Simetriks ??" +isSimetric);
        //      }

        //class MyClass
        //  {

        //  }          



        //int n = int.Parse(Console.ReadLine());
        //int[] arr = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    arr[i] = int.Parse(Console.ReadLine());
        //}


        //int[] Array = new int[] { 1, 2, 3, 4, 5 };
        //int lenght = Array.Length;

        //int[] reversed = new int[lenght];

        //for (int i = 0; i < lenght; i++)
        //{
        //    reversed[lenght - i - 1] = Array[i];         
        //    }







        //    string[] mystrArray = new string[]
        //    {
        //        "monday",
        //        "thusday"
        //        ,"wednesday"
        //        ,"thursday"
        //        ,"friday"
        //        ,"saturday"
        //        , "sunday"
        //};
        //    Console.WriteLine(mystrArray.Length);
        //    for (int i = 0; i < mystrArray.Length; i++)
        //    {
        //        Console.WriteLine(mystrArray[i ]);
        //    }
    }
}

    

