using System;

namespace Game
{
    public class Snake : SnakeGame
    {
        public int GetPartAheadX(int place)
        {
            place += 1;
            int x = locationsX[place];
            return x;
        }
        public int GetPartAheadY(int place)
        {
            place += 1;
            int y = locationsY[place];
            return y;

        }
        private List<int> newlocationsX = new List<int>();
        private List<int> newlocationsY = new List<int>();
        private void MoveUp()
        {
            int i = 0;
            for (int index = 0; index <= locationsX.Count - 2; index++)
            {
                int Newx = GetPartAheadX(i);
                newlocationsX[index] = Newx;
                i++;
            }
            int indexy = locationsY.Count - 1;
            int NY = locationsY[indexy];
            NY--;
            newlocationsY[indexy] = NY;
            i = 0;
            for (int index = 0; index <= locationsX.Count - 2; index++)
            {
                int Newy = GetPartAheadY(i);
                newlocationsY[index] = Newy;
                i++;
            }
        }
        private void MoveLeft()
        {
            int i = 0;
            for (int index = 0; index <= locationsX.Count - 2; index++)
            {

                int Newx = GetPartAheadX(i);
                newlocationsX[index] = Newx;
                i++;
            }
            i = 0;
            int index2 = locationsX.Count - 1;
            int LX = locationsX[index2];
            LX -= 1;
            newlocationsX[index2] = LX;
            for (int x = 0; x <= locationsX.Count - 2; x++)
            {
                int Newx = GetPartAheadY(i);
                newlocationsY[x] = Newx;
                i++;
            }
        }
        private void MoveRight()
        {
            int i = 0;
            for (int index = 0; index <= locationsX.Count - 2; index++)
            {
                int Newx = GetPartAheadX(i);
                newlocationsX[index] = Newx;
                i++;
            }
            i = 0;
            int index2 = locationsX.Count - 1;
            int z = locationsX[index2];
            z += 1;
            newlocationsX[index2] = z;
            for (int x = 0; x <= locationsX.Count - 2; x++)
            {

                int NewX = GetPartAheadY(i);
                newlocationsY[x] = NewX;
                i++;
            }
        }
        private void MoveDown()
        {
            int i = 0;
            for (int index = 0; index <= locationsX.Count - 2; index++)
            {

                int NewY = GetPartAheadX(i);
                newlocationsX[index] = NewY;
                i++;

            }

            int index2 = locationsY.Count - 1;
            int LY = locationsY[index2];
            LY++;
            newlocationsY[index2] = LY;
            i = 0;
            for (int index = 0; index <= locationsX.Count - 2; index++)
            {

                int NewY = GetPartAheadY(i);
                newlocationsY[index] = NewY;
                i++;
            }
        }
        
        public void Move(Snake snake, int[] pointscords, bool firstmove = true)
        {

            if (SnakeGame.GameContinueing == true)
            {
                int head = snake.locationsX[snake.locationsX.Count - 1];
                int headY = snake.locationsY[snake.locationsY.Count - 1];

                if (head == 2 || head == 99 || headY == 1 || headY == 25)
                {
                    GameContinueing = false;
                    Console.Clear();
                    GameOver(snake);
                }

                for (int i = 0; i <= snake.locationsX.Count - 2; i++)
                {
                    if (head == locationsX[i] && headY == locationsY[i])
                    {
                        GameContinueing = false;
                        Console.Clear();
                        GameOver(snake);
                    }
                }
                foreach (int content in locationsX)
                {
                    newlocationsX.Add(content);
                }
                foreach (int content in locationsY)
                {
                    newlocationsY.Add(content);
                }

                if (snake.positionMoving == "R" && CanMoveRight == true)
                {
                    MoveRight();
                }
                else if (snake.positionMoving == "L" && CanMoveLeft == true)
                {
                    MoveLeft();
                }
                else if (snake.positionMoving == "U" && CanMoveUp == true)
                {
                    MoveUp();
                }
                else if (snake.positionMoving == "D" && CanMoveDown == true)
                {
                    MoveDown();
                }

                for (int variable = 0; variable <= locationsX.Count - 1; variable++)
                {
                    int oldx = locationsX[variable];
                    int oldy = locationsY[variable];
                    Console.SetCursorPosition(oldx, oldy);
                    Console.Write("\b ");
                }
                if (newlocationsX[newlocationsX.Count - 1] == SnakeGame.dotx && newlocationsY[newlocationsY.Count - 1] == SnakeGame.doty)
                {
                    Grow(pointscords);
                }
                else
                {
                    for (int variable = 0; variable <= locationsX.Count - 1; variable++)
                    {
                        int x = newlocationsX[variable];
                        int y = newlocationsY[variable];
                        Console.SetCursorPosition(x, y);
                        Console.Write("\b█");
                    }
                }
                for (int variable = 0; variable <= locationsX.Count - 1; variable++)
                {
                    locationsX[variable] = newlocationsX[variable];
                    locationsY[variable] = newlocationsY[variable];
                }
            }
            else
            {
                Console.Clear();
            }
            
            Thread.Sleep(difficulty);
        }
        private void Grow(int[] pointscords)
        {
            Points++;
            newlocationsX.Insert(0, newlocationsX[0]);
            newlocationsY.Insert(0, newlocationsY[0]);
            locationsX.Insert(0, newlocationsX[0]);
            locationsY.Insert(0, newlocationsY[0]);
            for (int variable = 0; variable <= locationsX.Count - 1; variable++)
            {
                int x = newlocationsX[variable];
                int y = newlocationsY[variable];
                Console.SetCursorPosition(x, y);
                Console.Write("\b█");
            }
            Console.CursorLeft = pointscords[0];
            Console.CursorTop = pointscords[1];
            Console.WriteLine("\b" + Points);
            Displaydot(snake, false);
        }
        public List<int> locationsX = new List<int>()
        {
            47, 48, 49, 50
        };
        public List<int> locationsY = new List<int>()
        {
            12, 12, 12, 12
        };
        public bool CanMoveLeft = false;
        public bool CanMoveRight = true;
        public bool CanMoveUp = true;
        public bool CanMoveDown = true;
        //R - right, L - left, U - up, D - down
        public string positionMoving = "R";
        public int Points = 0;
        public bool haseaten = false;
    }
    public class SnakeGame
    {
        public static int difficulty = 250;
        public static int dotx;
        public static int doty;
        public static bool GameContinueing = true;
        private static int[] Display()
        {                                                                                                                         //100
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
        private static int RandomX()
        {
            Random rand = new Random();
            return rand.Next(2, 100);
        }
        private static int RandomY()
        {
            Random rand = new Random();
            return rand.Next(1, 26);
        }
        public static void Displaydot(Snake snake, bool GameBegun)
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
                    dotx = x;
                    doty = y;
                }
            }
        }
        public static Snake snake = new Snake();
        private static void DisplaySnake(int size = 4)
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
        public static void Arrow()
        {
            ConsoleKeyInfo key;
            while (GameContinueing == true)
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
        private static void DisplayGameOver()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("██████       ██████    ████    ████   ███████      ██████    ██    ██   ██████   ██████");
            Console.WriteLine("██          ██    ██   ██ ██  ██  ██  ██          ██    ██   ██    ██   ██       ██   ██");
            Console.WriteLine("██   ███    ████████   ██  ██ ██  ██  ███████     ██    ██    ██  ██    ██████   ██████");
            Console.WriteLine("██     ██   ██    ██   ██   ███   ██  ██          ██    ██     ████     ██       ██   ██");
            Console.WriteLine(" ██████     ██    ██   ██    ██   ██  ███████      ██████       ██      ██████   ██   ██");

            Console.WriteLine("\nPoints: " + snake.Points + "\n");
        }
        public static void GameOver(Snake snake)
        {
            DisplayGameOver();
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
                        DisplayGameOver();
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
                        DisplayGameOver();
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
                Game.SnakeGame.Restart();

            }
        }
        public static void Restart()
        {
            snake = null;
            Start(true);
        }
        public static void Start(bool restarted = false, int difficulty = 250)
        {
            SnakeGame.difficulty = difficulty;
            if (restarted == true)
            {
                snake = new Snake();
                GameContinueing = true;
            }

            Thread movement = new Thread(new ThreadStart(Arrow));
            
            movement.Start();
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            int[] cords = Display();
            Displaydot(snake, false);
            DisplaySnake();
            while (GameContinueing == true)
            {

                snake.Move(snake, cords, false);

                if (GameContinueing == false)
                {
                    break;
                }

            }
            Console.Clear();
            GameOver(snake);
        }
    }
}