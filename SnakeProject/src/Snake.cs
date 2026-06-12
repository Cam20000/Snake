using Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Snake.src
{
    public class Snake
    {
        public List<int> LocationX = new List<int>()
        {
            47, 48, 49, 50
        };
        public List<int> LocationY = new List<int>()
        {
            12, 12, 12, 12
        };

        private List<int> NewLocationX = new List<int>();
        private List<int> NewLocationY = new List<int>();

        public int FruitX;
        public int FruitY;
        public bool CanMoveLeft = false;
        public bool CanMoveRight = true;
        public bool CanMoveUp = true;
        public bool CanMoveDown = true;
        //R - right, L - left, U - up, D - down
        public string Direction = "R";
        public int Points = 0;
        public bool HasEaten = false;

        public int GetPartAheadX(int index)
        {
            index += 1;
            return LocationX[index];
            
        }
        public int GetPartAheadY(int index)
        {
            index += 1;
            return LocationY[index];

        }
        
        private void MoveUp()
        {
            int CurrentPart = 0;
            for (int index = 0; index <= LocationX.Count - 2; index++)
            {
                int NextX = GetPartAheadX(CurrentPart);
                NewLocationX[index] = NextX;
                CurrentPart++;
            }
            int IndexY = LocationY.Count - 1;
            int Y = LocationY[IndexY];
            Y--;
            NewLocationY[IndexY] = Y;
            CurrentPart = 0;
            for (int index = 0; index <= LocationX.Count - 2; index++)
            {
                int NextY = GetPartAheadY(CurrentPart);
                NewLocationY[index] = NextY;
                CurrentPart++;
            }
        }
        private void MoveLeft()
        {
            int CurrentPart = 0;
            for (int index = 0; index <= LocationX.Count - 2; index++)
            {

                int NextX = GetPartAheadX(CurrentPart);
                NewLocationX[index] = NextX;
                CurrentPart++;
            }
            CurrentPart = 0;
            int IndexX = LocationX.Count - 1;
            int X = LocationX[IndexX];
            X -= 1;
            NewLocationX[IndexX] = X;
            for (int Y = 0; Y <= LocationX.Count - 2; Y++)
            {
                int NextY = GetPartAheadY(CurrentPart);
                NewLocationY[Y] = NextY;
                CurrentPart++;
            }
        }

        private void MoveRight()
        {
            int CurrentPart = 0;
            for (int index = 0; index <= LocationX.Count - 2; index++)
            {
                int NextX = GetPartAheadX(CurrentPart);
                NewLocationX[index] = NextX;
                CurrentPart++;
            }
            CurrentPart = 0;
            int IndexX = LocationX.Count - 1;
            int X = LocationX[IndexX];
            X += 1;
            NewLocationX[IndexX] = X;
            for (int Y = 0; Y <= LocationX.Count - 2; Y++)
            {

                int NextY = GetPartAheadY(CurrentPart);
                NewLocationY[Y] = NextY;
                CurrentPart++;
            }
        }
        private void MoveDown()
        {
            int i = 0;
            for (int index = 0; index <= LocationX.Count - 2; index++)
            {

                int NextX = GetPartAheadX(i);
                NewLocationX[index] = NextX;
                i++;

            }

            int IndexY = LocationY.Count - 1;
            int Y = LocationY[IndexY];
            Y++;
            NewLocationY[IndexY] = Y;
            i = 0;
            for (int indexY = 0; indexY <= LocationX.Count - 2; indexY++)
            {

                int NewY = GetPartAheadY(i);
                NewLocationY[indexY] = NewY;
                i++;
            }
        }

        public bool Move(Snake snake, int[] PointsScored, Display display) //returns game status
        {
            int HeadX = snake.LocationX[snake.LocationX.Count - 1];
            int HeadY = snake.LocationY[snake.LocationY.Count - 1];

            if (HeadX == 2 || HeadX == 99 || HeadY == 1 || HeadY == 25)
            {
                
                Console.Clear();
                return false;
            }
            for (int i = 0; i <= snake.LocationX.Count - 2; i++)
            {
                if (HeadX == LocationX[i] && HeadY == LocationY[i])
                {
                    
                    Console.Clear();
                    return false;
                }
                
            }

            foreach (int X in LocationX)
            {
                NewLocationX.Add(X);
            }
            foreach (int Y in LocationY)
            {
                NewLocationY.Add(Y);
            }

            if (snake.Direction == "R" && CanMoveRight == true)
            {
                MoveRight();
            }
            else if (snake.Direction == "L" && CanMoveLeft == true)
            {
                MoveLeft();
            }
            else if (snake.Direction == "U" && CanMoveUp == true)
            {
                MoveUp();
            }
            else if (snake.Direction == "D" && CanMoveDown == true)
            {
                MoveDown();
            }

            for (int i = 0; i <= LocationX.Count - 1; i++)
            {
                int OldX = LocationX[i];
                int OldY = LocationY[i];
                Console.SetCursorPosition(OldX, OldY);
                Console.Write("\b ");
            }
            if (NewLocationX[NewLocationX.Count - 1] == FruitX && NewLocationY[NewLocationY.Count - 1] == FruitY)
            {
                Grow(PointsScored, display);
            }
            else
            {
                for (int i = 0; i <= LocationX.Count - 1; i++)
                {
                    int x = NewLocationX[i];
                    int y = NewLocationY[i];
                    Console.SetCursorPosition(x, y);
                    Console.Write("\b█");
                }
            }
            for (int i = 0; i <= LocationX.Count - 1; i++)
            {
                LocationX[i] = NewLocationX[i];
                LocationY[i] = NewLocationY[i];
            }
            return true;

        }
        private void Grow(int[] PointsCoordinates, Display display)
        {
            Points++;
            NewLocationX.Insert(0, NewLocationX[0]);
            NewLocationY.Insert(0, NewLocationY[0]);
            LocationX.Insert(0, NewLocationX[0]);
            LocationY.Insert(0, NewLocationY[0]);
            for (int variable = 0; variable <= LocationX.Count - 1; variable++)
            {
                int x = NewLocationX[variable];
                int y = NewLocationY[variable];
                Console.SetCursorPosition(x, y);
                Console.Write("\b█");
            }
            Console.CursorLeft = PointsCoordinates[0];
            Console.CursorTop = PointsCoordinates[1];
            Console.WriteLine("\b" + Points);
            display.Displaydot(this, false);
        }
        
        
    }
}
