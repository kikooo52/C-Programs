using System;
using System.Collections.Generic;

namespace Problem_3___Cooking
{
    class Program
    {
        private static List<double> quantitiesOfRecipe;
        private static List<string> measurementUnitsOfRecipe;
        private static List<string> productsOfRecipe;
 
        private static List<double> quantitiesOfRecipeKrisi;
        private static List<string> measurementKrisi;
        private static List<string> productKrisi;

        private static string[] stringSplit;
        private static string[] stringSplitKrisi;

        private static double qunatityDifference;
        private static string ingredient;

        static void Main(string[] args)
        {

            quantitiesOfRecipe = new List<double>();
            measurementUnitsOfRecipe = new List<string>();
            productsOfRecipe = new List<string>();
            Console.Write("Enter N:");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter ingredient of recipe {Quantity}:{Measurement unit}:{Product}:");
                ingredient = Console.ReadLine();
                stringSplit = ingredient.ToLower().Split(':');
                quantitiesOfRecipe.Add(double.Parse(stringSplit[0]));
                measurementUnitsOfRecipe.Add(stringSplit[1]);
                productsOfRecipe.Add(stringSplit[2]);
            }
            Console.WriteLine();
            CollectInputIngredientsKrisi();
            ConvertMillilitersToLiters();
            CheckIngredient();           
        }

        private static void CollectInputIngredientsKrisi()
        {
            quantitiesOfRecipeKrisi = new List<double>();
            measurementKrisi = new List<string>();
            productKrisi = new List<string>();
            Console.Write("Enter M, choise on Krisi for recipe:");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter ingredient of recipe of Krisi {Quantity}:{Measurement unit}:{Product}:");
                string ingredientKrisi = Console.ReadLine();             
                stringSplitKrisi = ingredientKrisi.ToLower().Split(':');
                quantitiesOfRecipeKrisi.Add(double.Parse(stringSplitKrisi[0]));
                measurementKrisi.Add(stringSplitKrisi[1]);
                productKrisi.Add(stringSplitKrisi[2]);
            }
        }
        private static void CheckIngredient()
        {
            bool discrepancy = false;
            for (int j = 0; j < productsOfRecipe.Count; j++)
            {
                for (int i = 0; i < productKrisi.Count; i++)
                {
                    if (productKrisi[i] == productsOfRecipe[j])
                    {
                        qunatityDifference = quantitiesOfRecipe[j] - quantitiesOfRecipeKrisi[i];
                        if ( qunatityDifference > 0 )
                        {
                            discrepancy = true;
                            Console.WriteLine("Krisi, you need to pour in {0} {1} of {2}", qunatityDifference, measurementUnitsOfRecipe[j], productsOfRecipe[j]);
                        }
                        break;
                    }

                    if ( (productKrisi.Count  - i) == 1)
                    {
                        discrepancy = true;
                        Console.WriteLine("Krisi, you need to pour in {0}:{1}:{2}", quantitiesOfRecipe[j], measurementUnitsOfRecipe[j], productsOfRecipe[j]); 
                    }
                }
            }

            if (!discrepancy)
            {
                Console.WriteLine("Krisi, you have done it all right!"); 
            }
        }

        private static void ConvertMillilitersToLiters()
        {
            for (int i = 0; i < measurementUnitsOfRecipe.Count; i++)
            {
                if (measurementUnitsOfRecipe[i] == "mls")
                {
                    quantitiesOfRecipe[i] = quantitiesOfRecipe[i] / 1000;
                }
            }
            for (int j = 0; j < measurementKrisi.Count; j++)
            {
                if (measurementKrisi[j] == "mls")
                {
                    quantitiesOfRecipeKrisi[j] = quantitiesOfRecipeKrisi[j] / 1000;
                }
            }

        }
    }
}

