using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Snake
    {
        static void Main(string[] args)
        {
            Horizontal_line newline = new Horizontal_line(5,10,3,'-');

            newline.Draw();
            //Point p1 = new Point(1, 2, '*');
            //p1.Draw();
            //Point p2 = new Point(4, 5, '#');
            //p2.Draw();
            //Point p3 = new Point(5, 6, '$');
            //p3.Draw();
            //Point p4 = new Point(3, 4, '%');
            //p4.Draw();
            //Point p5 = new Point(6, 7, '^');
            //p5.Draw();
            //Console.WriteLine();
            //Console.WriteLine("Вывод списка");
            //List<Point> numlist = new List<Point>();
            //numlist.Add(p1);
            //numlist.Add(p2);
            //numlist.Add(p3);
            //numlist.Add(p4);
            //numlist.Add(p5);
            //Console.WriteLine("Cписок создан:");
            //foreach (Point i in numlist)
            //{
            //    i.Draw();
            //}
            //numlist.Remove(p3);
            //p3.Draw();
            //Console.WriteLine();
            //foreach (Point pointer in numlist)
            //{
            //    pointer.Draw();
            //}
            //numlist.RemoveAt(2);
            //foreach (Point pointer in numlist)
            //{
            //    pointer.Draw();
            //}
            Console.ReadLine();
        }
    }
}
