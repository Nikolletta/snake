using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {
        }

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Move(int offset, Direction dir)
        {
            if (dir == Direction.right) x = x + offset;
          else  if (dir == Direction.left) x = x - offset;
          else  if (dir == Direction.up) y = y - offset;
          else  if (dir == Direction.down) y = y + offset;
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }
    }
}
