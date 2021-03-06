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
			int CurentPosition = Initial;
            int Moves = 0;
            Console.WriteLine("Hello Welcome To Snake And Lader Problem ");
            Console.WriteLine("Start Game"); while (CurentPosition != Wining)
			{
				Random value = new Random();
				int valueOfDice = value.Next(1, 7);
				Console.WriteLine("Player rolled : " + valueOfDice);
				int actionTaken = value.Next(0, 3);
				if (actionTaken == No_Play)
				{
					Console.WriteLine("No action taken");
				}
				else if (actionTaken == Ladder)
				{
					CurentPosition += valueOfDice;
					if (CurentPosition > Wining)
					{
						CurentPosition -= valueOfDice;
					}
				}
				else
				{
					CurentPosition -= valueOfDice;
					if (CurentPosition < Initial)
					{
						CurentPosition = Initial;
					}
				}
				Moves++;
				Console.WriteLine("You Are At Position : " + CurentPosition);
			}
			Console.WriteLine("You reached exact winning position in : " + Moves + " moves");
		}
	}
}