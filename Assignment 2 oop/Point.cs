namespace Assignment_2_oop
{
    internal struct Point
    {
        public double X;
        public double Y;
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public static double Distance(Point p1, Point p2)
        {
            double x = p2.X - p1.X;
            double y = p2.Y - p1.Y;
            return Math.Sqrt(x * x + y * y);
        }
    }
}
