
class Låt
{
    public string Titel { get; set; }
    public string Artist { get; set; }

    public Låt(string titel, string artist)
    {
        Titel = titel;
        Artist = artist;
    }

    public override string ToString() => $"{Titel} - {Artist}";
}
class Spellista
{
    public string Namn { get; set; }
    private List<Låt> _låtar;
    public Spellista(string namn)
    { 
        Namn = namn;
        _låtar = new List<Låt>();
    }
    public void LäggTillLåt(Låt nyLåt)
    {
        if(nyLåt != null)
        {
            _låtar.Add(nyLåt);
        }
    }
   
    public void SkrivUtLåtar()
    {
        Console.WriteLine($"Låtar i spellistan [{Namn}]:");
        foreach (Låt låt in _låtar)
        {
            Console.WriteLine(låt);
        }
        Console.WriteLine();
    }
}
class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("12 Spellistan");
        Console.Title = "12 Spellistan";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Spellista spellista1 = new Spellista("Spellista 1");
        spellista1.LäggTillLåt(new Låt("Låt 1", "Artist 1"));
        spellista1.LäggTillLåt(new Låt("Låt 2", "Artist 2"));
        spellista1.LäggTillLåt(new Låt("Låt 3", "Artist 3"));
        spellista1.LäggTillLåt(new Låt("Låt 4", "Artist 4"));
        spellista1.LäggTillLåt(new Låt("Låt 5", "Artist 5"));

        Spellista spellista2 = new Spellista("Spellista 2");
        spellista2.LäggTillLåt(new Låt("Låt 6", "Artist 6"));
        spellista2.LäggTillLåt(new Låt("Låt 7", "Artist 7"));
        spellista2.LäggTillLåt(new Låt("Låt 8", "Artist 8"));
        spellista2.LäggTillLåt(new Låt("Låt 9", "Artist 9"));
        
        spellista1.SkrivUtLåtar();
        spellista2.SkrivUtLåtar();

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}
