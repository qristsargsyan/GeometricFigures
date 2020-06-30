using System;

namespace GeometricFigures
{
    class Square
    {

        public void DrawSquare()
        {

            Console.WriteLine("We are going to draw square please enter the width ");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the heigth ");
            int h = int.Parse(Console.ReadLine());

            for (int i = 0; i < h; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < w; j++)
                {

                    if (i == 0 || i == h - 1 || j == 0 || j == w - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.WriteLine("\n");

        }
    }
}
