using System;
using System.IO;

class WritingTextFiles
{
    static void Main()
    {
        string fileName = "numbers.txt";
        StreamWriter streamWriter = new StreamWriter(fileName);
        using (streamWriter)
        {
            for (int number = 1; number <= 202; number++)
            {
                streamWriter.WriteLine(number);
            }
        }
        StreamReader streamReader = new StreamReader(fileName);
        using (streamReader)
        {
            string fileContents = streamReader.ReadToEnd();
            Console.WriteLine(fileContents);
        }
        Console.WriteLine("File is written!");
    }
}
