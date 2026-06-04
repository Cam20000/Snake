using Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Snake.src
{
    public class Display
    {
        private void DisplayGameOverText(Snake snake)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("██████       ██████    ████    ████   ███████      ██████    ██    ██   ██████   ██████");
            Console.WriteLine("██          ██    ██   ██ ██  ██  ██  ██          ██    ██   ██    ██   ██       ██   ██");
            Console.WriteLine("██   ███    ████████   ██  ██ ██  ██  ███████     ██    ██    ██  ██    ██████   ██████");
            Console.WriteLine("██     ██   ██    ██   ██   ███   ██  ██          ██    ██     ████     ██       ██   ██");
            Console.WriteLine(" ██████     ██    ██   ██    ██   ██  ███████      ██████       ██      ██████   ██   ██");
            Console.WriteLine("\nPoints: " + snake.Points + "\n");
        }
        public void DisplayGameOver(Game.Game game, Snake snake)
        {
            DisplayGameOverText(snake);
            
            string OptionSelected = "RESTART";
            ConsoleKeyInfo key;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("RESTART");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("EXIT");
            while (true)
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (OptionSelected == "RESTART") //sets to EXIT
                    {
                        Console.Clear();
                        DisplayGameOverText(snake);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("RESTART");
                        Console.WriteLine("MAIN MENU");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("EXIT");
                        OptionSelected = "EXIT";
                    }
                    else if (OptionSelected == "MAIN MENU")
                    {
                        Console.Clear();
                        DisplayGameOverText(snake);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("RESTART");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("MAIN MENU");
                        Console.WriteLine("EXIT");
                        OptionSelected = "RESTART";
                    }
                    else if (OptionSelected == "EXIT")
                    {
                        Console.Clear();
                        DisplayGameOverText(snake);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("RESTART");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("MAIN MENU");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("EXIT");
                        OptionSelected = "MAIN MENU";
                    }
                    
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    if (OptionSelected == "RESTART") //sets to EXIT
                    {
                        Console.Clear();
                        DisplayGameOverText(snake);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("RESTART");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("MAIN MENU");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("EXIT");
                        OptionSelected = "MAIN MENU";
                    }
                    else if (OptionSelected == "MAIN MENU")
                    {
                        Console.Clear();
                        DisplayGameOverText(snake);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("RESTART");
                        Console.WriteLine("MAIN MENU");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("EXIT");
                        OptionSelected = "EXIT";
                    }
                    else if (OptionSelected == "EXIT")
                    {
                        Console.Clear();
                        DisplayGameOverText(snake);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("RESTART");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("MAIN MENU");
                        Console.WriteLine("EXIT");
                        OptionSelected = "RESTART";
                    }
                }
                if (key.Key == ConsoleKey.Spacebar)
                {
                    break;
                }
            }
            if (OptionSelected == "EXIT")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Environment.Exit(1);
            }
            if (OptionSelected == "MAIN MENU")
            {
                Console.Clear();
                
                DisplayMainMenu("START");
            }
            if (OptionSelected == "RESTART")
            {
                Console.Clear();
                game.Restart();
            }
        }
        public int DisplayMainMenu(string OptionSelected)
        {
            int difficulty = 250;

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
                return difficulty; //Starts the game
            }
            else if (OptionSelected == "EXIT")
            {
                Environment.Exit(1);
            }
            else if (OptionSelected == "DIFFICULTY")
            {
                difficulty = DisplayDifficulty();
                DisplayMainMenu(OptionSelected);
            }
            return 0;

        }
        public void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                      ███████  ███   ██   ██████   ██    ██  ██████");
            Console.WriteLine("                                      ██       ████  ██  ██    ██  ██   ██   ██");
            Console.WriteLine("                                       █████   █████ ██  ████████  ██████    ██████");
            Console.WriteLine("                                           ██  ██  ████  ██    ██  ██   ██   ██");
            Console.WriteLine("                                      ██████   ██   ███  ██    ██  ██    ██  ██████");

        }
        public int DisplayDifficulty()
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
                    switch (optionSelected)
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

        public int[] Show(Snake snake)
        {
            Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████");
            for (int i = 0; i <= 24; i++)
            {
                Console.WriteLine("█                                                                                                  █");
            }
            Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.Write("\nPoints: " + snake.Points);
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            int[] cords = { x, y };
            return cords;
        }
        private int RandomX()
        {
            Random rand = new Random();
            return rand.Next(2, 100);
        }
        private int RandomY()
        {
            Random rand = new Random();
            return rand.Next(1, 26);
        }
        public void Displaydot(Snake snake, bool GameBegun)
        {
            var x = RandomX();
            int y = RandomY();
            if (!snake.haseaten)
            {
                if (GameBegun)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("\bO");
                }
                else
                {
                    foreach (var value in snake.locationsX)
                    {
                        if (x == value)
                        {
                            Displaydot(snake, false);
                        }
                    }
                    foreach (var value in snake.locationsY)
                    {
                        if (y == value)
                        {
                            Displaydot(snake, false);
                        }
                    }
                    Console.SetCursorPosition(x, y);
                    Console.Write("\bO");
                    snake.dotx = x;
                    snake.doty = y;
                }
            }
        }
        public void DisplaySnake(int size = 4)
        {
            Console.SetCursorPosition(47, 12);
            Console.Write("\b█");
            Console.SetCursorPosition(48, 12);
            Console.Write("\b█");
            Console.SetCursorPosition(49, 12);
            Console.Write("\b█");
            Console.SetCursorPosition(50, 12);
            Console.Write("\b█");
        }
    }
}
