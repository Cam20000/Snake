using System;
using Game;
namespace main
{
    public class Snake
    {
        
        


        private static void MainMenu(string OptionSelected)
        {
            DisplayLogo();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("START");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("EXIT");
            OptionSelected = "START";

            Console.ForegroundColor = ConsoleColor.Black;

            ConsoleKeyInfo key;
            while (true)
            {

                key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (OptionSelected != "START")
                    {
                        Console.Clear();
                        DisplayLogo();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("START");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("EXIT");
                        OptionSelected = "START";
                    }
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    if (OptionSelected == "START")
                    {
                        Console.Clear();
                        DisplayLogo();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("START");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("EXIT");
                        OptionSelected = "EXIT";
                    }
                }
                if (key.Key == ConsoleKey.Spacebar)
                {
                    break;
                }

            }

            if (OptionSelected != "START")
            {
                Environment.Exit(1);
            }
            else
            {
                Console.Clear();
                Game.SnakeGame.Start(); //Starts the game

            }

        }
        private static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                      ███████  ███   ██   ██████   ██    ██  ██████");
            Console.WriteLine("                                      ██       ████  ██  ██    ██  ██   ██   ██");
            Console.WriteLine("                                       █████   █████ ██  ████████  ██████    ██████");
            Console.WriteLine("                                           ██  ██  ████  ██    ██  ██   ██   ██");
            Console.WriteLine("                                      ██████   ██   ███  ██    ██  ██    ██  ██████");

        }





        public static void Main()
        {
            Console.CursorVisible = false;
            MainMenu("START");


            Console.ReadLine();
        }
    }
}