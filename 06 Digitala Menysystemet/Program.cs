
interface IKlickbar
{
    void Klicka();
}

class MenyVal : IKlickbar
{
    public void Klicka()
        => Console.WriteLine("Menyvalet öppnas.");
}

class Ikon : IKlickbar
{
    public void Klicka()
        => Console.WriteLine("Ikonen aktiveras.");
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("06 Digitala Menysystemet");
        Console.Title = "06 Digitala Menysystemet";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        List<IKlickbar> klickbara =
        [
            new MenyVal(),
            new Ikon(),
            new MenyVal(),
            new Ikon()
        ];

        foreach (IKlickbar objekt in klickbara)
        {
            objekt.Klicka();
        }

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}
