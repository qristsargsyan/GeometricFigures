namespace GeometricFigures
{
    class Program
    {
        static void Main(string[] args)
        {

            Square sq = new Square();
            Drawer.PrintSquare(sq);
            Triangle tr = new Triangle();
            Drawer.PrintTriangle(tr);
            RectangularTriangle rect = new RectangularTriangle();
            Drawer.PrintRectangularTriangle(rect);

        }
    }
}
