using System;
using Game;
using Snake.src;
namespace main
{
    public class Program
    {
        public static void Main()
        {
            Display display = new Display();
            Console.CursorVisible = false;
            int difficulty = display.DisplayMainMenu("START");
            Snake.src.Snake snake = new Snake.src.Snake();
            Game.Game game = new Game.Game(difficulty,snake, display);
            game.Start(difficulty);
            Console.ReadLine();
        }

    }
}