
class VaktLista
{
    private readonly string[] _vakter = new string[24];
    public VaktLista()
    {
        for (int i = 0; i < _vakter.Length; i++)
        {
            _vakter[i] = "Ingen tilldelad vakt";
        }
    }
    public string this[int timme]
    {
        get
        {
            if (timme < 0 || timme >= _vakter.Length)
            {
                Console.WriteLine("Fel: Timmen måste vara mellan 0 och 23.");
                return "Ledig tid";
            }
            return _vakter[timme];
        }
        set
        {
            if (timme < 0 || timme >= _vakter.Length)
            {
                Console.WriteLine("Fel: Timmen måste vara mellan 0 och 23.");
                return;
            }
            _vakter[timme] = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("06 Båtbesättnings VaktLista");
        Console.Title = "06 Båtbesättnings VaktLista";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        VaktLista vaktLista = new VaktLista();
        vaktLista[8] = "Anna";
        vaktLista[20] = "Bertil";

        for (int i = 0; i < 24; i++)
        {
            Console.WriteLine($"Timme {i}: {vaktLista[i]}");
        }


        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}

