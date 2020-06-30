namespace GeometricFigures
{
    class Drawer
    {

        public static void PrintSquare(Square sq)
        {
            sq.DrawSquare();
        }

        public static void PrintTriangle(Triangle tr)
        {
            tr.DrawTriangle();
        }

        public static void PrintRectangularTriangle(RectangularTriangle rect)
        {
            rect.DrawRectangular();
        }

    }
}
