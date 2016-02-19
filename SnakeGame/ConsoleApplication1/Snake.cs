using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Snake :Figure
    {
        Direction dir;

        public Snake(Point tail, int lenght, Direction _dir)
        {
            dir = _dir;
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, dir);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, dir);
            return nextPoint;
        }

        internal bool Eat(Point food)
        {
           // Point head = GetNextPoint();
            Point head = pList.Last();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else return false;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                dir = Direction.left;
            if (key == ConsoleKey.RightArrow)
                dir = Direction.right;
            if (key == ConsoleKey.UpArrow)
                dir = Direction.up;
            if (key == ConsoleKey.DownArrow)
                dir = Direction.down;
        }
    }
}
