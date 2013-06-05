using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3___Cooking
{
    class Program
    {
        private static List<double> quantityRecipe;
        private static List<string> measurement;
        private static List<string> product;
        private static string[] stringsplit;
        private static List<double> quantityOfRecipeKrisi;
        private static List<string> measurementKrisi;
        private static List<string> productKrisi;
        private static string[] stringsplitKrisi;
        private static double result;
        private static string ToLower;
        private static string ingredient;
        private static string ToLowerKrisi;
        private static int counter;


        static void Main(string[] args)
        {

            quantityRecipe = new List<double>();
            measurement = new List<string>();
            product = new List<string>();
            Console.Write("Enter N:");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter ingredient of recipe {Quantity}:{Measurement unit}:{Product}:");
                ingredient = Console.ReadLine();
                ToLower = ingredient.ToLower();
                stringsplit = ToLower.Split(':');
                quantityRecipe.Add(double.Parse(stringsplit[0]));
                measurement.Add(stringsplit[1]);
                product.Add(stringsplit[2]);
            }
            Console.WriteLine();
            IngredientKrisi();
            ConvertMillilitersToLiters();
            CheckIngredient();
            


        }

        private static void IngredientKrisi()
        {
            quantityOfRecipeKrisi = new List<double>();
            measurementKrisi = new List<string>();
            productKrisi = new List<string>();
            Console.Write("Enter M, choise on Krisi for recipe:");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter ingredient of recipe of Krisi {Quantity}:{Measurement unit}:{Product}:");
                string ingredientKrisi = Console.ReadLine();             
                ToLowerKrisi = ingredientKrisi.ToLower();
                stringsplitKrisi = ToLowerKrisi.Split(':');
                quantityOfRecipeKrisi.Add(double.Parse(stringsplitKrisi[0]));
                measurementKrisi.Add(stringsplitKrisi[1]);
                productKrisi.Add(stringsplitKrisi[2]);
            }
        }
        private static void CheckIngredient()
        {
            for (int j = 0; j < productKrisi.Count; j++)
            {
                for (int i = 0; i < product.Count; i++)
                {
                    if (productKrisi[j] == product[i])
                    {
                        if (quantityOfRecipeKrisi[j] < quantityRecipe[i])
                        {
                            result = quantityRecipe[i] - quantityOfRecipeKrisi[j];
                            counter = i;
                            break;
                        }
                    }
                    if (result == 0)
                    {
                        result = quantityRecipe.Sum();
                        counter = i;
                    }
                   
                }
            }
            Console.WriteLine(result + ":" + measurement[counter] + ":" + product[counter]);
        }

        private static void ConvertMillilitersToLiters()
        {
            for (int i = 0; i < measurement.Count; i++)
            {
                if (measurement[i] == "mls")
                {
                    quantityRecipe[i] = quantityRecipe[i] / 1000;
                }
            }
            for (int j = 0; j < measurementKrisi.Count; j++)
            {
                if (measurementKrisi[j] == "mls")
                {
                    quantityOfRecipeKrisi[j] = quantityOfRecipeKrisi[j] / 1000;
                }
            }

        }
    }
}

