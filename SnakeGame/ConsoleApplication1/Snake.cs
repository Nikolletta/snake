﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Snake :Figure
    {

        public Snake(Point tail, int lenght, Direction dir)
        {
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, dir);
                pList.Add(p);
            }
        }

    }
}
