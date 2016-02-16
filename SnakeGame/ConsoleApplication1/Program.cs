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

            List<int> newlist = new List<int>();
            newlist.Add(0);
            newlist.Add(1);
            newlist.Add(2);

            int x = newlist[0];
            int y = newlist[1];
            int z = newlist[2];

            foreach(int i in newlist)
            {
                Console.WriteLine(i);
            }

            List<Point> pList = new List<Point>;
            pList.Add(p1);
            pList.Add(p2);

            Console.ReadLine();
        }
    }
}
