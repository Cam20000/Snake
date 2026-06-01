using System;
using Game;
using Snake.src;
namespace main
{
    public class Program
    {

        /*
         Have it so that main method handles game code, Game and Snake are just for the logic of the game, and Display is just for the display of the game.

         */

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