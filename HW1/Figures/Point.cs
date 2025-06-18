public class Point: IPrintable
{
    public int X { get; set; }

    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    
public void Print()
    {
        Console.WriteLine($" I am Point with coordinates X {X} and Y {Y}");
    }
}