using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake_Game");
            Console.WriteLine("");

            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorLine l1 = new HorLine(5, 10, 8, '+');
            l1.Draw();

            VerLine v1 = new VerLine(5, 9, 12, '*');
            v1.Draw();

            Console.ReadLine();
        }
    }
}
