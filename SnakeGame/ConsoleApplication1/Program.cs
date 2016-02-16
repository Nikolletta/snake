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
            Console.SetBufferSize(80, 25);

            //отрисоква рамки
            HorLine upLine = new HorLine(0, 78, 0, '+');
            HorLine downLine = new HorLine(0, 78, 24, '+');
            VerLine leftLine = new VerLine(0, 0, 24, '+');
            VerLine rightLine = new VerLine(78, 0, 24, '+');

            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Console.ReadLine();
        }
    }
}
