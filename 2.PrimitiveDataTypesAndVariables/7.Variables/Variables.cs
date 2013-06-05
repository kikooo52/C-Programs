using System;

class Variables
{
    static void Main(string[] args)
    {
        string hello = "Hello ";
        string My = "my ";
        string world = "world!";
        object full = hello + My + world;
        string convert = (string)full;
        Console.WriteLine(convert);
    }
}
