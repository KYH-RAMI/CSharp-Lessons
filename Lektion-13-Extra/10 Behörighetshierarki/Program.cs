
class Användare
{
    private string _lösenord;
    protected string _användarnivå;

    public Användare(string lösenord, string användarnivå)
    {
        _lösenord = lösenord;
        _användarnivå = användarnivå;
    }

    public bool KontrolleraLösenord(string lösenord)
        => lösenord == _lösenord;
}

class Administrator : Användare
{
    public Administrator(string lösenord, string användarnivå)
        : base(lösenord, användarnivå) { }

    public string LäsAnvändarnivå()
        => _användarnivå;

    public void SkrivAnvändarnivå(string nyAnvändarnivå)
        => _användarnivå = nyAnvändarnivå;

}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("10 Behörighetshierarki");
        Console.Title = "10 Behörighetshierarki";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Administrator admin = new Administrator("1234", "Admin");
        Console.WriteLine($"Användarnivå: {admin.LäsAnvändarnivå()}");
        admin.SkrivAnvändarnivå("SuperAdmin");
        Console.WriteLine($"Användarnivå: {admin.LäsAnvändarnivå()}");
        Console.WriteLine($"Lösenord korrekt: {admin.KontrolleraLösenord("1234")}");

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}