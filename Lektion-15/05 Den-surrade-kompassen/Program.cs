
class DigitalKompass
{
    private int _aktuellKurs;
    public int Kurs
    {
        get => _aktuellKurs;
        private set => _aktuellKurs = value;
    }
    public void UppdateraKurs(int nyKurs)
    {
        if (nyKurs < 0 || nyKurs > 359)
        {
            throw new ArgumentOutOfRangeException(
                nameof(nyKurs),
                "Kursen måste vara mellan 0 och 359 grader.");
        }
        Kurs = nyKurs;
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("05 Den surrade kompassen");
        Console.Title = "05 Den surrade kompassen";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        DigitalKompass kompass = new DigitalKompass();

        kompass.UppdateraKurs(180);
        Console.WriteLine($"Aktuell kurs: {kompass.Kurs}°");

        try
        {
            kompass.UppdateraKurs(400);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Fel: {ex.Message}");
            Console.ResetColor();
        }

        Console.WriteLine($"Kurs efter felaktigt försök: {kompass.Kurs}°");


        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}