using Snake.src;
using System;
using System.Runtime.CompilerServices;
namespace Game
{
    public class Game
    {
        private int Difficulty = 250;
        private bool GameContinueing = true;
        private Snake.src.Snake snake;
        private Display display;
        public Game(int Difficulty, Snake.src.Snake snake, Display display)
        {
            this.Difficulty = Difficulty;
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
                    snake.Direction = "L";
                    snake.CanMoveRight = false;
                    snake.CanMoveDown = true;
                    snake.CanMoveLeft = true;
                    snake.CanMoveUp = true;
                }
                if (key.Key == ConsoleKey.RightArrow && snake.CanMoveRight == true)
                {
                    snake.Direction = "R";
                    snake.CanMoveRight = true;
                    snake.CanMoveDown = true;
                    snake.CanMoveLeft = false;
                    snake.CanMoveUp = true;
                }
                if (key.Key == ConsoleKey.DownArrow && snake.CanMoveDown == true)
                {
                    snake.Direction = "D";
                    snake.CanMoveRight = true;
                    snake.CanMoveDown = true;
                    snake.CanMoveLeft = true;
                    snake.CanMoveUp = false;
                }
                if (key.Key == ConsoleKey.UpArrow && snake.CanMoveUp == true)
                {
                    snake.Direction = "U";
                    snake.CanMoveDown = false;
                    snake.CanMoveLeft = true;
                    snake.CanMoveRight = true;
                    snake.CanMoveUp = true;
                }
            }
        }
        
        
        public void Restart()
        {
            snake = null;
            Start(Difficulty, true);
        }
        public void Start(int Difficulty, bool restarted = false)
        {
            this.Difficulty = Difficulty;
            if (restarted == true)
            {
                snake = new Snake.src.Snake();
                GameContinueing = true;
            }
            Thread movement = new Thread(new ThreadStart(Arrow));
            movement.Start();
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            int[] Cordinatess = display.Show(snake);
            display.Displaydot(snake, false); 
            display.DisplaySnake();
            while (GameContinueing == true)
            {
                GameContinueing = snake.Move(snake, Cordinatess, display); //snake.Move() returns the game's status

                if (GameContinueing == false)
                {
                    Console.Clear();
                    break;
                }
                Thread.Sleep(Difficulty);
            }
            Console.Clear();
            display.DisplayGameOver(this, snake);
        }
    }
}