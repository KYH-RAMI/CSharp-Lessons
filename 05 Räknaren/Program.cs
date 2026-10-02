
class StepCounter
{
    private int _steps;
    public int Steps
    {
        get { return _steps; }
    }
    public void AddStep()
    {
        _steps++;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Steg tillagda. Totalt antal steg: {_steps}");
        Console.ResetColor();
    }
    public void Reset()
    {
        _steps = 0;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Stegräknaren har återställts.");
        Console.ResetColor();
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("05 Räknaren");
        Console.Title = "05 Räknaren";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        StepCounter counter = new StepCounter();
        counter.AddStep();
        counter.AddStep();
        counter.AddStep();
        counter.AddStep();
        counter.AddStep();
        Console.WriteLine($"Avläst via Steps: {counter.Steps} \n");
        counter.Reset();
        Console.WriteLine($"Avläst via Steps: {counter.Steps} \n");
        counter.AddStep();
        counter.AddStep();
        counter.AddStep();
        Console.WriteLine($"Slutligt antal steg: {counter.Steps} \n");

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}