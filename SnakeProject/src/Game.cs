using Snake.src;
using System;
using System.Runtime.CompilerServices;
namespace Game
{
    public class Game
    {
        private int difficulty = 250;
        private bool GameContinueing = true;
        private Snake.src.Snake snake;
        private Display display;
        public Game(int difficulty, Snake.src.Snake snake, Display display)
        {
            this.difficulty = difficulty;
            this.snake = snake;
            this.display = display;
        }

        
        
        public void Arrow()
        {
            ConsoleKeyInfo key;
            while (this.GameContinueing == true)
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.LeftArrow && snake.CanMoveLeft == true)
                {
                    snake.positionMoving = "L";
                    snake.CanMoveRight = false;
                    snake.CanMoveDown = true;
                    snake.CanMoveLeft = true;
                    snake.CanMoveUp = true;
                }
                if (key.Key == ConsoleKey.RightArrow && snake.CanMoveRight == true)
                {
                    snake.positionMoving = "R";
                    snake.CanMoveRight = true;
                    snake.CanMoveDown = true;
                    snake.CanMoveLeft = false;
                    snake.CanMoveUp = true;
                }
                if (key.Key == ConsoleKey.DownArrow && snake.CanMoveDown == true)
                {
                    snake.positionMoving = "D";
                    snake.CanMoveRight = true;
                    snake.CanMoveDown = true;
                    snake.CanMoveLeft = true;
                    snake.CanMoveUp = false;
                }
                if (key.Key == ConsoleKey.UpArrow && snake.CanMoveUp == true)
                {
                    snake.positionMoving = "U";
                    snake.CanMoveDown = false;
                    snake.CanMoveLeft = true;
                    snake.CanMoveRight = true;
                    snake.CanMoveUp = true;
                }
            }
        }
        
        private void GameOver()
        {
            display.DisplayGameOver(snake);
            ConsoleKeyInfo key;
            string OptionSelected = "RESTART";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("RESTART");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("EXIT");
            while (true)
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (OptionSelected != "RESTART")
                    {
                        Console.Clear();
                        display.DisplayGameOver(snake);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("RESTART");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("EXIT");
                        OptionSelected = "RESTART";
                    }
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    if (OptionSelected == "RESTART")
                    {
                        Console.Clear();
                        display.DisplayGameOver(snake);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("RESTART");
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
            if (OptionSelected != "RESTART")
            {
                Environment.Exit(1);
            }
            else
            {
                Console.Clear();
                Restart();

            }
        }
        private void Restart()
        {
            snake = null;
            Start(difficulty, true);
        }
        public void Start(int difficulty, bool restarted = false)
        {
            this.difficulty = difficulty;
            if (restarted == true)
            {
                snake = new Snake.src.Snake();
                GameContinueing = true;
            }
            Thread movement = new Thread(new ThreadStart(Arrow));
            movement.Start();
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            int[] cords = display.Show(snake);
            display.Displaydot(snake, false); 
            display.DisplaySnake();
            while (GameContinueing == true)
            {
                GameContinueing = snake.Move(snake, cords, display); //snake.Move() returns the game's status

                if (GameContinueing == false)
                {
                    Console.Clear();
                    break;
                }
                Thread.Sleep(difficulty);
            }
            Console.Clear();
            GameOver();
        }
    }
}