using System;
using Game;
namespace main
{
    public class Program
    {
        public static int difficulty = 250;
        
        //ONLY FOR TESTS
        private static int Difficulty()
        {
            Console.Clear();
            string optionSelected = "0.25";
            Console.WriteLine("Difficulty effects the speed of the snake, the number represents the amount of seconds the snake has before it moves.");
            Console.WriteLine("Default: 0.25 seconds");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("0.25 seconds");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("0.20 second");
            Console.WriteLine("0.10 seconds");
            Console.WriteLine("0.08 seconds");
            ConsoleKeyInfo key;
            while (true)
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    switch (optionSelected)
                    {
                        case "0.08":
                            Console.Clear();
                            optionSelected = "0.10";
                            Console.WriteLine("Difficulty effects the speed of the snake, the number represents the amount of seconds the snake has before it moves.");
                            Console.WriteLine("Default: 0.25 seconds");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("0.25 seconds");
                            Console.WriteLine("0.20 second");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("0.10 seconds");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("0.08 seconds");
                            break;
                        case "0.10":
                            Console.Clear();
                            optionSelected = "0.20";
                            Console.WriteLine("Difficulty effects the speed of the snake, the number represents the amount of seconds the snake has before it moves.");
                            Console.WriteLine("Default: 0.25 seconds");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("0.25 seconds");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("0.20 second");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("0.10 seconds");
                            Console.WriteLine("0.08 seconds");
                            break;
                        case "0.20":
                            Console.Clear();
                            optionSelected = "0.25";
                            Console.WriteLine("Difficulty effects the speed of the snake, the number represents the amount of seconds the snake has before it moves.");
                            Console.WriteLine("Default: 0.25 seconds");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("0.25 seconds");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("0.20 second");
                            Console.WriteLine("0.10 seconds");
                            Console.WriteLine("0.08 seconds");
                            break;
                    }
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    switch (optionSelected)
                    {
                        case "0.25":
                            Console.Clear();
                            optionSelected = "0.20";
                            Console.WriteLine("Difficulty effects the speed of the snake, the number represents the amount of seconds the snake has before it moves.");
                            Console.WriteLine("Default: 0.25 seconds");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("0.25 seconds");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("0.20 second");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("0.10 seconds");
                            Console.WriteLine("0.08 seconds");
                            break;
                        case "0.20":
                            Console.Clear();
                            optionSelected = "0.10";
                            Console.WriteLine("Difficulty effects the speed of the snake, the number represents the amount of seconds the snake has before it moves.");
                            Console.WriteLine("Default: 0.25 seconds");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("0.25 seconds");
                            Console.WriteLine("0.20 second");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("0.10 seconds");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("0.08 seconds");
                            break;
                        case "0.10":
                            Console.Clear();
                            optionSelected = "0.08";
                            Console.WriteLine("Difficulty effects the speed of the snake, the number represents the amount of seconds the snake has before it moves.");
                            Console.WriteLine("Default: 0.25 seconds");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("0.25 seconds");
                            Console.WriteLine("0.20 second");
                            Console.WriteLine("0.10 seconds");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("0.08 seconds");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }
                }
                else if (key.Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    switch(optionSelected)
                    {
                        case "0.25":
                            return 250;
                        break;
                        case "0.20":
                            return 200;
                        break;
                        case "0.10":
                            return 100;
                        break;
                        case "0.08":
                            return 80;
                        break;

                            
                    }
                    
                }
            }
        }
        private static void MainMenu(string OptionSelected)
        {
            
            DisplayLogo();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("START");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("DIFFICULTY");
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
                    if (OptionSelected == "DIFFICULTY")
                    {
                        //sets to START
                        Console.Clear();
                        DisplayLogo();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("START");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("DIFFICULTY");
                        Console.WriteLine("EXIT");
                        OptionSelected = "START";
                    }
                    if (OptionSelected == "EXIT")
                    {
                        //sets to difficulty
                        Console.Clear();
                        DisplayLogo();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("START");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("DIFFICULTY");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("EXIT");
                        OptionSelected = "DIFFICULTY";
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
                        Console.WriteLine("DIFFICULTY");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("EXIT");
                        OptionSelected = "DIFFICULTY";
                    }
                    else if (OptionSelected == "DIFFICULTY")
                    {
                        Console.Clear();
                        DisplayLogo();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("START");
                        Console.WriteLine("DIFFICULTY");
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
            if (OptionSelected == "START")
            {
                Console.Clear();
                Game.SnakeGame.Start(false, difficulty); //Starts the game
            }
            else if (OptionSelected == "EXIT")
            {
                Environment.Exit(1);
            }
            else if (OptionSelected == "DIFFICULTY")
            {
                difficulty = Difficulty();
                MainMenu(OptionSelected);
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