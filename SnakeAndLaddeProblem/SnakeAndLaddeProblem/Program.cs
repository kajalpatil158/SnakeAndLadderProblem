using System;

namespace SnakeAndLader
{
    class Program
    {
        public const int Start = 0;
        public const int END_POINT = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome To Snake And Lader Problem ");
            string player1 = Console.ReadLine();
            int playerPosition = Start;
            Console.WriteLine("Current Position : " + playerPosition);
        }
    }
}