using System;

class PossibleCardsWithoutJokers
{
    static void Main(string[] args)
    {
     

       
        for (int i = 1; i <= 4; i++)
        {
            switch (i)
            {
                case 1: Console.WriteLine("\"Diamonds\"- 2,3,4,5,6,7,8,9,10,J,Q,K,A");
                    break;
                case 2: Console.WriteLine("\"Clubs\"- 2,3,4,5,6,7,8,9,10,J,Q,K,A");
                    break;
                case 3: Console.WriteLine("\"Hearts\"- 2,3,4,5,6,7,8,9,10,J,Q,K,A");
                    break;
                case 4: Console.WriteLine("\"Spades\"- 2,3,4,5,6,7,8,9,10,J,Q,K,A");
                    break;
            }



            //string[] t = new string[4] { "Diamonds: ", "Clubs: ", "Hearts: ", "Spades: " };
            //Console.Write("\n\t\t\t\t" + t[i - 1]);


            //for (int j = 1; j <= 13; j++)
            //{
            //    string[] r = new string[13] { "\"2,", "3,", "4,", "5,", "6,", "7,", "8,", "9,", "10,", "J,", "Q,", "K,", "A\"" };
            //    Console.Write(r[j - 1]);
            //}
            //Console.WriteLine();
            
        }
    }
}

  