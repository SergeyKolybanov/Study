using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Vertical_line : Figure
    {
        pList = new List<Point>();
        public Vertical_line(int x, int yUp, int yDown, char sym)
        {
            for (int y = yUp; y < yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
