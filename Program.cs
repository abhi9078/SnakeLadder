using System;

namespace SnakeLadder
{
    internal class Program
    {
        public static void UC_1()
        {
            Console.WriteLine("Welcome to Snake and Ladder Problem");
            Console.WriteLine("Snake and ladder game played with singel player start at zero");
        }

        public static void UC_2()
        {
            Console.WriteLine("Welcome to UC-2 program");
            Random rnd = new Random();
            int num=rnd.Next(1,7);
            Console.WriteLine("The Random Dice Number is: " + num);
        }
        static void Main(string[] args)
        {
            Program.UC_1();
            Program.UC_2();
        }
    }
}
