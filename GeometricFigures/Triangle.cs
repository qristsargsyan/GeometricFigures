using System;

namespace GeometricFigures
{
    class Triangle
    {

        public void DrawTriangle()
        {
            Console.WriteLine("We are going to draw triangle please enter the size ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {

                for (int j = n; j >= i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    if (k == 1 || k == (2 * i - 1) || i == n)
                        Console.Write(".");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();

            }

            Console.WriteLine();
        }
    }
}
