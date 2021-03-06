using System;

namespace SnakeAndLader
{
	class Program
	{
		public const int Start = 0;
		public const int End = 100;
		public const int No_Play = 0;
		public const int Snake = 1;
		public const int Ladder = 2;
		public const int Initial = 0;
		public const int Wining = 100;
		static void Main(string[] args)
		{
			int player1 = Initial;
			int player2 = Initial;
			bool FirstPlayer = true;
			Console.WriteLine("Hello Welcome To Snake And Lader Problem ");
			Console.WriteLine("Game Start Between Two Players: ");
			while (player1 != Wining && player2 != Wining)
			{
				if (FirstPlayer)
				{


					Random value = new Random();
					int diceValue = value.Next(1, 7);
					Console.WriteLine("First Player rolled Dice: " + diceValue);
					int actionTaken = value.Next(0, 3);
					if (actionTaken == No_Play)
					{
						FirstPlayer = false;
					}
					else if (actionTaken == Ladder)
					{
						player1 += diceValue;
						if (player1 > Wining)
						{
							player1 -= diceValue;
						}
					}
					else
					{
						FirstPlayer = false;
						player1 -= diceValue;
						if (player1 < Initial)
						{
							player1 = Initial;
						}
					}
				}

				else
				{
					Random random = new Random();
					int diceValue = random.Next(1, 7);
					Console.WriteLine("Second Player rolled Dice : " + diceValue);
					Random random1 = new Random();

					int actionTaken = random1.Next(0, 3);
					if (actionTaken == No_Play)
					{
						FirstPlayer = true;
					}
					else if (actionTaken == Ladder)
					{
						player2 += diceValue;
						if (player2 > Wining)
						{
							player2 -= diceValue;
						}
					}
					else
					{
						FirstPlayer = true;
						player2 -= diceValue;
						if (player2 < Initial)
						{
							player2 = Initial;
						}
					}
				}
			}
			if (player1 == Wining)
			{
				Console.WriteLine("Player 1 won the game");
			}
			else
			{
				Console.WriteLine("Player 2 won the game");
			}
		}
	}
}
