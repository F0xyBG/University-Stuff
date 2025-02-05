namespace JDataHiding;

class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public void Move(double delta)
    {
        this.X += delta;
        this.Y += delta;
    }
}
