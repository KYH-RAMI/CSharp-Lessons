
class TungData
{
    public TungData()
    {
        Console.WriteLine("TungData laddas....");
    }
}
class KundRapport
{
    private Lazy<TungData> _tungData;
    public KundRapport()
    {
        _tungData = new Lazy<TungData>(() => new TungData());
    }
    public void VisaLayout()
    {
        Console.WriteLine("Rapportens layout");
    }
    public void VisaData()
    {
        Console.WriteLine(_tungData.Value);
    }
}


class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("15 Den tröga rapporten (Lazy Initialization)");
        Console.Title = "15 Den tröga rapporten (Lazy Initialization)";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        KundRapport rapport = new KundRapport();
        rapport.VisaLayout();
        Console.WriteLine();
        rapport.VisaData();
        Console.WriteLine();
        rapport.VisaData();


        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}