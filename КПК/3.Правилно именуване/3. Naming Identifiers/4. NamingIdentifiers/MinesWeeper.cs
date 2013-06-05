using System;
using System.Collections.Generic;
using System.Linq;

namespace Mines
{
    class MinesWeeper
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
			char[,] putField = CreatePlayField();
			char[,] putBomb = CreateBombField();
			int counter = 0;
			bool thunder = false;
			List<Scores> champions = new List<Scores>(6);
			int row = 0;
			int column = 0;
			bool startGame = true;
			const int MaxScore = 35;
			bool endGame = false;

			do
			{
				if (startGame)
				{
				    Console.WriteLine("Lets start Game”.Try you look and find places without mines"); 
                    Console.WriteLine("Enter 'top' to view top players");
                    Console.WriteLine("Enter 'restart' to begin new game");
                    Console.WriteLine("Enter 'exit' to close the game");
					DrawPlayField(putField);
					startGame = false;
				}

				Console.Write("Enter row and colomn: ");
				command = Console.ReadLine();
                string[] arr =  command.Split();

				if (command.Length >= 3)
				{
                    if (int.TryParse(arr[0].ToString(), out row) &&
                    int.TryParse(arr[1].ToString(), out column) &&
						row <= putField.GetLength(0) && column <= putField.GetLength(1))
					{
						command = "turn";
					}
				}

				switch (command)
				{
					case "top":
						RankList(champions);
						break;
					case "restart":
						putField = CreatePlayField();
						putBomb = CreateBombField();
						DrawPlayField(putField);
						thunder = false;
						startGame = false;
						break;
					case "exit":
                        Console.WriteLine("Bye Bye Bye!");
						break;
					case "turn":
						if (putBomb[row, column] != '*')
						{
							if (putBomb[row, column] == '-')
							{
								Muving(putField, putBomb, row, column);
								counter++;
							}
							if (MaxScore == counter)
							{
								endGame = true;
							}
							else
							{
								DrawPlayField(putField);
							}
						}
						else
						{
							thunder = true;
						}
						break;
					default:
						Console.WriteLine("\nError! invalid command\n");
						break;
				}

				if (thunder)
				{
					DrawPlayField(putBomb);
					Console.Write("\n Game Over! your score are: {0} . " +
						"Your Name plase: ", counter);

					string nickName = Console.ReadLine();
					Scores playerScore = new Scores(nickName, counter);

					if (champions .Count < 5)
					{
						champions.Add(playerScore);
					}
					else
					{
						for (int i = 0; i < champions .Count; i++)
						{
							if (champions [i].Score < playerScore.Score)
							{
								champions .Insert(i, playerScore);
								champions .RemoveAt(champions.Count - 1);
								break;
							}
						}
					}

                    champions.Sort((Scores firstPlayer, Scores secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    champions.Sort((Scores firstPlayer, Scores secondPlayer) => secondPlayer.Score.CompareTo(firstPlayer.Score));
					RankList(champions );

					putField = CreatePlayField();
					putBomb = CreateBombField();
					counter = 0;
					thunder = false;
					startGame = true;
				}

				if (endGame)
				{
                    Console.WriteLine("\nCongratulations! achieved a perfect score 35.");
					DrawPlayField(putBomb);
					Console.WriteLine("You are champion! enter name:");
					string name = Console.ReadLine();
                    Scores score = new Scores(name, counter);
					champions .Add(score);
					RankList(champions);
					putField = CreatePlayField();
					putBomb = CreateBombField();
					counter = 0;
					endGame = false;
					startGame = true;
				}
			}

			while (command != "exit");
			Console.WriteLine("Made in Bulgaria!");
			Console.Read();
		}

		private static void RankList(List<Scores> score)
		{
			Console.WriteLine("\nScore:");

			if (score.Count > 0)
			{
				for (int i = 0; i < score.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} points",
						i + 1, score[i].Name, score[i].Score);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("empty RankList!\n");
			}
		}

		private static void Muving(char[,] field, char[,] bomb, int row, int col)
		{
			char countBombs = GetBombCount(bomb, row, col);
			bomb[row, col] = countBombs;
			field[row, col] = countBombs;
		}

		private static void DrawPlayField(char[,] playField)
		{
			int row = playField.GetLength(0);
			int col = playField.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");

			for (int i = 0; i < row; i++)
			{
				Console.Write("{0} | ", i);
				for (int j = 0; j < col; j++)
				{
					Console.Write(string.Format("{0} ", playField[i, j]));
				}
				Console.Write("|");
				Console.WriteLine();
			}

			Console.WriteLine("    ---------------------\n");
		}

		private static char[,] CreatePlayField()
		{
			int fieldRow = 5;
			int fieldColumn = 10;   
			char[,] playField = new char[fieldRow, fieldColumn];

			for (int row = 0; row < fieldRow; row++)
			{
				for (int col = 0; col < fieldColumn; col++)
				{
					playField[row, col] = '?';
				}
			}

			return playField;
		}

		private static char[,] CreateBombField()
		{
			int rows = 5;
			int column = 10;
			char[,] bombField = new char[rows, column];

			for (int r = 0; r < rows; r++)
			{
				for (int c = 0; c < column; c++)
				{
					bombField[r, c] = '-';
				}
			}

			List<int> map = new List<int>();

			while (map.Count < 15)
			{
				Random random = new Random();
				int randomBomb = random.Next(50);
				if (!map.Contains(randomBomb))
				{
					map.Add(randomBomb);
				}
			}

			foreach (int bomb in map)
			{
				int col = (bomb / column);
				int row = (bomb % column);

				if (row == 0 && bomb != 0)
				{
					col--;
					row = column;
				}
				else
				{
					row++;
				}

				bombField[col, row - 1] = '*';
			}

			return bombField;
		}

		private static char GetBombCount(char[,] bombField, int row, int col)
		{
			int bombCount = 0;
			int rows = bombField.GetLength(0);
			int cols = bombField.GetLength(1);

			if (row - 1 >= 0)
			{
				if (bombField[row - 1, col] == '*')
				{ 
					bombCount++; 
				}
			}

			if (row + 1 < rows)
			{
				if (bombField[row + 1, col] == '*')
				{ 
					bombCount++; 
				}
			}

			if (col - 1 >= 0)
			{
				if (bombField[row, col - 1] == '*')
				{ 
					bombCount++;
				}
			}

			if (col + 1 < cols)
			{
				if (bombField[row, col + 1] == '*')
				{ 
					bombCount++;
				}
			}

			if ((row - 1 >= 0) && (col - 1 >= 0))
			{
				if (bombField[row - 1, col - 1] == '*')
				{ 
					bombCount++; 
				}
			}

			if ((row - 1 >= 0) && (col + 1 < cols))
			{
				if (bombField[row - 1, col + 1] == '*')
				{ 
					bombCount++; 
				}
			}

			if ((row + 1 < rows) && (col - 1 >= 0))
			{
				if (bombField[row + 1, col - 1] == '*')
				{ 
					bombCount++; 
				}
			}

			if ((row + 1 < rows) && (col + 1 < cols))
			{
				if (bombField[row + 1, col + 1] == '*')
				{ 
					bombCount++; 
				}
			}

			return char.Parse(bombCount.ToString());
		}
	}
}

			

