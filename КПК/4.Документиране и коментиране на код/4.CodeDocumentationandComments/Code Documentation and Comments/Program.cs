using System;
using System.Linq;

namespace StringExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "TTT";
            Console.WriteLine(value.ToMd5Hash());
            Console.WriteLine(StringExtensions.ToBoolean("ok"));
            Console.WriteLine(StringExtensions.ToShort("68"));
            Console.WriteLine(StringExtensions.ToInteger("1267890"));
            Console.WriteLine(StringExtensions.ToLong("4324234234234324234"));
            Console.WriteLine(StringExtensions.ToDateTime("20013/4/30 15:31:00"));
            Console.WriteLine(StringExtensions.CapitalizeFirstLetter("totot"));
            Console.WriteLine(StringExtensions.GetStringBetween("Jusus is my Lord, and who is your?", "is", "your", 2));
            Console.WriteLine(StringExtensions.ConvertCyrillicToLatinLetters("AAaa Чики Вв Бб Щище Кики мики тики фрики Аки"));
            Console.WriteLine(StringExtensions.ToValidUsername("+kksS$@Trr/**++"));
            Console.WriteLine(StringExtensions.ToValidLatinFileName("Ки$№%$№РОО%$"));
            Console.WriteLine(StringExtensions.GetFirstCharacters("LIKKOOOOOOOO", 7));
            Console.WriteLine(StringExtensions.GetFileExtension("Ted.txt"));
            Console.WriteLine(StringExtensions.ToContentType("jpg"));
            Console.WriteLine(StringExtensions.ToByteArray("asdas"));
        }
    }
}
