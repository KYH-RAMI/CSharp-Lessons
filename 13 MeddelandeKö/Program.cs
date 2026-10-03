
record NödSignal(string Avsändare, int Allvarhetsgrad);

class MeddelandeKö<T>
{
    private readonly List<T> _kö = new List<T>();
    public void Enqueue(T item)
    {
        _kö.Add(item);
        Console.WriteLine("[LOGG] Element tillagt i kön.");
    }
    public T Dequeue()
    {
        if (_kö.Count == 0)
        {
            throw new InvalidOperationException("Kön är tom.");
        }
        T item = _kö[0];
        _kö.RemoveAt(0);
        Console.WriteLine("[LOGG] Element hämtat och borttaget från kön.");
        return item;
    }
    public int Antal => _kö.Count;
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("13 Generisk Meddelandekö");
        Console.Title = "13 Generisk Meddelandekö";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        MeddelandeKö<string> textKö = new MeddelandeKö<string>();

        textKö.Enqueue("Meddelande 1");
        textKö.Enqueue("Meddelande 2");
        textKö.Enqueue("Meddelande 3");

        Console.WriteLine($"Ut ur kön: {textKö.Dequeue()}");
        Console.WriteLine($"Ut ur kön: {textKö.Dequeue()}");
        Console.WriteLine($"Antal kvar: {textKö.Antal}");

        MeddelandeKö<NödSignal> nödKö = new MeddelandeKö<NödSignal>();

        nödKö.Enqueue(new NödSignal("Båt Aurora", 3));
        nödKö.Enqueue(new NödSignal("Båt Viking", 5));
        nödKö.Enqueue(new NödSignal("Båt Stella", 2));

        Console.WriteLine($"Ut ur kön: {nödKö.Dequeue()}");
        Console.WriteLine($"Ut ur kön: {nödKö.Dequeue()}");
        Console.WriteLine($"Antal kvar: {nödKö.Antal}");


        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}