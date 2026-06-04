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
        public List<int> locationsX = new List<int>()
        {
            47, 48, 49, 50
        };
        public List<int> locationsY = new List<int>()
        {
            12, 12, 12, 12
        };
        public int dotx;
        public int doty;
        public bool CanMoveLeft = false;
        public bool CanMoveRight = true;
        public bool CanMoveUp = true;
        public bool CanMoveDown = true;
        //R - right, L - left, U - up, D - down
        public string positionMoving = "R";
        public int Points = 0;
        public bool haseaten = false;

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

        public bool Move(Snake snake, int[] pointscords, Display display) //returns game status
        {
            int head = snake.locationsX[snake.locationsX.Count - 1];
            int headY = snake.locationsY[snake.locationsY.Count - 1];

            if (head == 2 || head == 99 || headY == 1 || headY == 25)
            {
                
                Console.Clear();
                return false;
            }
            for (int i = 0; i <= snake.locationsX.Count - 2; i++)
            {
                if (head == locationsX[i] && headY == locationsY[i])
                {
                    
                    Console.Clear();
                    return false;
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
            if (newlocationsX[newlocationsX.Count - 1] == dotx && newlocationsY[newlocationsY.Count - 1] == doty)
            {
                Grow(pointscords, display);
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
            return true;

        }
        private void Grow(int[] pointscords, Display display)
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
            display.Displaydot(this, false);
        }
        
        
    }
}
