
struct Position
{
    public int X { get; set; }
    public int Y { get; set; }

    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }
    public void VisaPosition()
    {
        Console.WriteLine($"[{X}, {Y}]");
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("02 Båtposition");
        Console.Title = "02 Båtposition";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Position pos1 = new Position(10, 20);
        Position pos2 = pos1;

        pos2.X = 99;

        pos1.VisaPosition();
        pos2.VisaPosition();

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}