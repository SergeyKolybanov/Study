using ConsoleApplication1;
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
            Console.WriteLine("Создаётся новая точка");
        }
        public Point (int _x, int _y, char _sym)
        {
            if (_x < Snake.x)
            {
                x = _x;
            }
            else
            {
                x = Snake.x;
            }
            if (_y < Snake.y)
            {
                y = _y;
            }
            else
            {
                y = Snake.y;
            }
            sym = _sym;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
