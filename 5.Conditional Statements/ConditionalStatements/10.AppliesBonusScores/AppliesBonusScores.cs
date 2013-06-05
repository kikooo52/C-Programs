using System;

class AppliesBonusScores
{
    static void Main()
    {
        Console.Write("Enter a digit between [1-9]:");
        int score = int.Parse(Console.ReadLine());

        if (score < 9 && score > 0)
        {
            switch (score)
            {
                case 1:
                case 2:
                case 3: Console.WriteLine("The digit is between \"1-3\", score:" + (score * 10));
                    break;
                case 4:
                case 5:
                case 6: Console.WriteLine("The digit is between \"4-6\", score:" + (score * 100));
                    break;
                case 7:
                case 8:
                case 9: Console.WriteLine("The digit is between \"7-9\", score:" + (score * 1000));
                    break;
            }
        }
        else
        {
            Console.WriteLine("The digit is out of range");
        }

    }
}

