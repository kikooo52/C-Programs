using System;


class IntDoubleOrStringVariable
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choice 1 for int:");
        Console.WriteLine("Choice 2 for double:");
        Console.WriteLine("Choice 3 for string:");
        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: Console.WriteLine("\nYour choice is \"int\" " + (choice + 1));
                break;
            case 2: Console.WriteLine("\nYour choice is \"double\" " + (choice + 1));
                break;
            case 3: Console.WriteLine("\nYour choice is \"string\" " + "*");
                break;
        }

    }
}

