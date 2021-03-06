using System;

namespace SnakeAndLader
{
    class Program
    {
        public const int Start = 0;
        public const int End = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome To Snake And Lader Problem ");
            string player1 = Console.ReadLine();
            int playerPosition = Start;
            Console.WriteLine("Current Position : " + playerPosition);
            int diceRoll = DiceRoll();
            Console.WriteLine("Dice Roll : " + diceRoll);
        }
        static int DiceRoll()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            return dice;
        }
    
    }
}