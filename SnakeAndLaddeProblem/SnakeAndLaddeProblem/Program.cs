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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome To Snake And Lader Problem ");
            string player1 = Console.ReadLine();
            int playerPosition = Start;
            Console.WriteLine("Current Position : " + playerPosition);
            int diceRoll = DiceRoll();
            Console.WriteLine("Dice Roll : " + diceRoll);
            playerPosition = Condition(diceRoll, playerPosition);
            Console.WriteLine("Your Position: " + playerPosition);
            if (playerPosition >= 100)
            {
                Console.WriteLine("Game Over");
                
            }
            Console.ReadLine();

        }
        static int DiceRoll()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            return dice;
        }
        static int Condition(int numberRolled, int playerPosition)
        {
            Random random = new Random();
            int move = random.Next(0, 3);
            switch (move)
            {
                case No_Play:
                    Console.WriteLine("No Play");
                    break;
                case Snake:
                    Console.WriteLine("You Are Bitten by Snake");
                    if (playerPosition - numberRolled >= 0)
                    {
                        playerPosition = playerPosition - numberRolled;
                        break;
                    }
                    else
                    {
                        playerPosition = Start;
                        break;
                    }
                case Ladder:
                    Console.WriteLine("You Got Ladder");
                    playerPosition = playerPosition + numberRolled;
                    break; ;
            }
            return playerPosition;
        }

    }
}