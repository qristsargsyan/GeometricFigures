using System;

namespace GeometricFigures
{
    public class Square
    {

        public void DrawSquare(int w,int h)
        {

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
