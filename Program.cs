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

        public static void UC_4()
        {
            int ladder = 1, ldice;
            int snake = 2, sdice;
            int win = 100;
            int count = 0;
            Console.WriteLine("Welcome to UC_4");
            while (count <= win)
            {
                if (count >= 0)
                {
                    Random random = new Random();
                    int randomCheck = random.Next(3);

                    switch (randomCheck)
                    {
                        case 1:
                            {
                                Random rnd = new Random();
                                ldice = rnd.Next(1, 7);
                                count = count + ldice;
                                Console.WriteLine("Got Ladder");
                                break;
                            }
                        case 2:
                            {
                                Random sran = new Random();
                                sdice = sran.Next(1, 7);
                                count = count - sdice;
                                Console.WriteLine("Got snake");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("No play");
                                break;
                            }
                    }
                }
                else
                {
                    count = 0;
                }
                
            }
            Console.WriteLine("Player wins" + count);
        }

        public static void UC_5()
        {
            int ladder = 1, ldice=0;
            int snake = 2, sdice;
            int win = 100;
            int count = 0,a=0;
            Console.WriteLine("Welcome to UC_5");
            while (count != win)
            {
                if (count >= 0 && count<100)
                {
                    Random random = new Random();
                    int randomCheck = random.Next(3);

                    switch (randomCheck)
                    {
                        case 1:
                            {
                                Console.WriteLine("Got Ladder");
                                Random rnd = new Random();
                                ldice = rnd.Next(1, 7);
                                count = count + ldice;
                                a = count;
                                break;
                            }
                        case 2:
                            {
                                Random sran = new Random();
                                sdice = sran.Next(1, 7);
                                count = count - sdice;
                                Console.WriteLine("Got snake");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("No play");
                                break;
                            }
                    }
                }
                else if (a > 100)
                {
                    count = a - ldice;
                }
                else
                {
                    count = 0;
                }

            }
            Console.WriteLine("Player wins" + count);
        }

        public static void UC_6()
        {
            int ladder = 1, ldice = 0;
            int snake = 2, sdice;
            int win = 100;
            int diceRoll = 0;
            int count = 0, a = 0;
            Console.WriteLine("Welcome to UC_6");
            while (count != win)
            {
                if (count >= 0 && count < 100)
                {
                    Random random = new Random();
                    int randomCheck = random.Next(3);
                    diceRoll++;

                    switch (randomCheck)
                    {
                        case 1:
                            {
                                Console.WriteLine("Got Ladder");
                                Random rnd = new Random();
                                ldice = rnd.Next(1, 7);
                                count = count + ldice;
                                Console.WriteLine("Position is "+count);
                                a = count;
                                break;
                            }
                        case 2:
                            {
                                Random sran = new Random();
                                sdice = sran.Next(1, 7);
                                count = count - sdice;
                                Console.WriteLine("Position is: "+count);
                                Console.WriteLine("Got snake");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("No play");
                                Console.WriteLine("Position is: "+count);
                                break;
                            }
                    }
                }
                else if (a > 100)
                {
                    count = a - ldice;
                }
                else
                {
                    count = 0;
                }

            }
            Console.WriteLine("Player wins" + count);
            Console.WriteLine("Number of time Dice Roll is to win: "+diceRoll);
        }
        static void Main(string[] args)
        {
            Program.UC_1();
            Program.UC_2();
            Program.UC_3();
            Program.UC_4();
            Program.UC_5();
            Program.UC_6();
        }
    }
}
