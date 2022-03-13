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

        public static void UC_3()
        {
            int ladder = 1, ldice;
            int snake = 2, sdice;
            Console.WriteLine("Welcome to UC_3");
            Random random = new Random();
            int randomCheck=random.Next(3);

            switch (randomCheck)
            {
                case 1:
                    {
                        Random rnd = new Random();
                        ldice = rnd.Next(1,7);
                        Console.WriteLine("Got Ladder");
                        break;
                    }
                case 2:
                    {
                        Random sran = new Random();
                        sdice = sran.Next(1,7);
                        Console.WriteLine("Got snake");
                        break ;
                    }
                default:
                    {
                        Console.WriteLine("No play, Stay at base");
                        break;
                    }
            }

        }
        static void Main(string[] args)
        {
            Program.UC_1();
            Program.UC_2();
            Program.UC_3();
        }
    }
}
