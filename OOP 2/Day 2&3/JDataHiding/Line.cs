namespace JDataHiding;

internal class Line
{
    public Point A { get; set; }
    public Point B { get; set; }

    public Line()
    {
        A = new Point(); B = new Point();
    }

    public Line(Point a, Point b)  
    {
        A = a;
        B = b;
    }

    public Line(double x1, double y1, double x2, double y2) : this()
    {
        A.X = x1; A.Y = y1;
        B.X = x2; B.Y = y2;
    }

    public double Length
    {
        get
        {
            double dx = A.X - B.X;
            double dy = A.Y - B.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }

    public Point this[int index]
    {
        get 
        {
            if (index == 0) return A;
            else if (index == 1) return B;
            else throw new IndexOutOfRangeException();
        }
    }


}
