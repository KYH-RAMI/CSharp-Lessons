
class Konto
{
    private string epost = "";
    public string Epost
    {
        get { return epost; }
        set
        {
            if (value.Contains("@"))
            {
                epost = value;
            }
            else
            {
                epost = "Ogiltig";
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("06 Inkapsling med privat fält och validering");
        Console.Title = "06 Inkapsling med privat fält och validering";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Konto konto = new Konto();
        konto.Epost = "test@test.se";
        Console.WriteLine(konto.Epost);
        konto.Epost = "test";
        Console.WriteLine(konto.Epost);

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}