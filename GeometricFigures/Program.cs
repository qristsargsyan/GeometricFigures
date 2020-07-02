using System;

namespace GeometricFigures
{
    class Program
    {
        static void Main(string[] args)
        {

            for (; ;)
            {

                Console.WriteLine("Please enter the number for drawing geometric figures \n1-Square   2-Triangle   3-Rectangular Triangle");
                string str = Console.ReadLine();

                switch (str)
                {
                    case "1":
                        Console.WriteLine("We are going to draw square please enter the width ");
                        int w = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter the heigth ");
                        int h = int.Parse(Console.ReadLine());
                        Square sq = new Square();
                        sq.DrawSquare(w,h);
                        break;
                    case "2":
                        Console.WriteLine("We are going to draw triangle please enter the size ");
                        int n = int.Parse(Console.ReadLine());
                        Triangle tr = new Triangle();
                        tr.DrawTriangle(n);
                        break;
                    case "3":
                        Console.WriteLine("We are going to draw rectangular triangle please enter the size ");
                        int n1 = int.Parse(Console.ReadLine());
                        RectangularTriangle rect = new RectangularTriangle();
                        rect.DrawRectangular(n1);
                        break;
                    default:
                        return;

                }

            }

        }
    }
}
