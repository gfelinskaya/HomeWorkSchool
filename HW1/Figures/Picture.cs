public class Picture : IPrintable
{
    readonly Point[] points;

    public Picture(Point[] points)
    {
        this.points = points;
    }

    public void Print()
    {
        foreach (Point point in points)
            {
                point.Print();
            }
    }
}