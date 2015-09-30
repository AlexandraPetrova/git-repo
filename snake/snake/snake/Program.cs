using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            /*Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();*/

            //рисуем рамочку
            HorisontalLine UpLine = new HorisontalLine(0, 78, 0, '+');
            HorisontalLine DownLine = new HorisontalLine(0, 78, 24, '+');
            VertikalLine LeftLine = new VertikalLine(0, 24, 0, '+');
            VertikalLine RightLine = new VertikalLine(0, 24, 78, '+');
            UpLine.Drow();
            DownLine.Drow();
            LeftLine.Drow();
            RightLine.Drow();

            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            p.Draw();

            Console.ReadLine();
        }

    }
}

