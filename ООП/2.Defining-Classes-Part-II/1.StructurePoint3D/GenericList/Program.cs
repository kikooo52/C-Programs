using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> arrayGenerics = new GenericList<int>(10);

            arrayGenerics.AddElement(4);
            arrayGenerics.AddElement(2222);
            arrayGenerics.AddElement(2212);
            arrayGenerics.Clear();
            arrayGenerics.AddElement(4);
            arrayGenerics.AddElement(2);
            arrayGenerics.AddElement(22222);
            arrayGenerics.RemoveElemenByIndext(0);

            arrayGenerics.InsertElement(0, 213321);
            arrayGenerics.RemoveElemenByIndext(0);
            Console.WriteLine(arrayGenerics.ToString());
            Console.WriteLine();
         
            Console.WriteLine("Max:"+arrayGenerics.Max());
            Console.WriteLine("Min:"+arrayGenerics.Min());
        }
    }
}
