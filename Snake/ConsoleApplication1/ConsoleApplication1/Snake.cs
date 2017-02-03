using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Snake
    {
        public const int x = 78; //sizes
        public const int y = 24; //sizes
        static void Main(string[] args)
        {
            
            Console.SetBufferSize(x+2, y+1);
            Horizontal_line Upline = new Horizontal_line(1, x, 0, '═');
            Horizontal_line DownLine = new Horizontal_line(1, x, y, '═');
            Vertical_line LeftLine = new Vertical_line(0, 1, y, '║');
            Vertical_line RightLine = new Vertical_line(x, 1, y, '║');
            //Draw conners
            Console.SetCursorPosition(0, 0);
            Console.Write('╔');
            Console.SetCursorPosition(x, 0);
            Console.Write('╗');
            Console.SetCursorPosition(0, y);
            Console.Write('╚');
            Console.SetCursorPosition(x, y);
            Console.Write('╝');
            Upline.Draw();
            DownLine.Draw();
            LeftLine.Draw();
            RightLine.Draw();
            Point p = new Point(3, 5, '*');
            p.Draw();
            Console.ReadLine();
        }
    }
}
