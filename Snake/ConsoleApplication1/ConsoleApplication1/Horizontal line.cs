﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Horizontal_line : ConsoleApplication1.Figure
    {
        pList = new List<Point>();
        public Horizontal_line(int xLeft, int xRight, int y, char sym)
        {
            for (int x = xLeft; x < xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }
    }
}
