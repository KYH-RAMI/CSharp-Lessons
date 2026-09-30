
class Användare
{
    public string Användarnamn { get; private set; }
    public string Lösenord { get; private set; }

    public Användare(string användarnamn, string lösenord)
    {
        Användarnamn = användarnamn;
        Lösenord = lösenord;
    }
    public void BytAnvändarnamn(string nyttAnvändarnamn)
    {
        Användarnamn = nyttAnvändarnamn;
    }
}
class Rapport
{
    public string Titel { get; set; }
    public Användare Författare { get; set; }

    public Rapport(string titel, Användare författare)
    {
        Titel = titel;
        Författare = författare;
    }

    public Rapport ShallowCopy()
    {
        return (Rapport)this.MemberwiseClone();
    }

    public Rapport DeepCopy()
    {
        return new Rapport(Titel, new Användare(Författare.Användarnamn, Författare.Lösenord));
    }

}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("13 Kloningsmaskinen");
        Console.Title = "13 Kloningsmaskinen";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Användare användare1 = new Användare("Rami", "1234");
        Rapport rapport1 = new Rapport("Rami Rapport", användare1);

        Rapport rapport2 = rapport1.ShallowCopy();
        Rapport rapport3 = rapport1.DeepCopy();

        Console.WriteLine($"Rapport 1 författare: {rapport1.Författare.Användarnamn}");
        Console.WriteLine($"Rapport 2 författare: {rapport2.Författare.Användarnamn}");
        Console.WriteLine($"Rapport 3 författare: {rapport3.Författare.Användarnamn}");

        Console.WriteLine("\nÄndrar användarnamn via shallow copy och deep copy");

        rapport2.Författare.BytAnvändarnamn("Rami2");

        Console.WriteLine($"\nEfter ändring av rapport 2:");
        Console.WriteLine($"Rapport 1 författare: {rapport1.Författare.Användarnamn}");
        Console.WriteLine($"Rapport 2 författare: {rapport2.Författare.Användarnamn}");
        Console.WriteLine($"Rapport 3 författare: {rapport3.Författare.Användarnamn}");

        rapport3.Författare.BytAnvändarnamn("Jonas");

        Console.WriteLine($"\nEfter ändring av rapport 3:");
        Console.WriteLine($"Rapport 1 författare: {rapport1.Författare.Användarnamn}");
        Console.WriteLine($"Rapport 2 författare: {rapport2.Författare.Användarnamn}");
        Console.WriteLine($"Rapport 3 författare: {rapport3.Författare.Användarnamn}");

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}