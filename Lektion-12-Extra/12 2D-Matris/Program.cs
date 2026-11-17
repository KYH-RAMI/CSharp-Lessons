
class SektionsLager
{
    private readonly string[,] _hyllor;
    public SektionsLager(int rader, int kolumner)
    {
        _hyllor = new string[rader, kolumner];
        for (int i = 0; i < rader; i++)
        {
            for (int j = 0; j < kolumner; j++)
            {
                _hyllor[i, j] = "[Tom]";
            }
        }
    }
    public string this[int rad, int kolumn]
    {
        get
        {
            if (rad < 0 || rad >= _hyllor.GetLength(0) || kolumn < 0 || kolumn >= _hyllor.GetLength(1))
            {
                throw new IndexOutOfRangeException("Index utanför gränserna för lagret.");
            }
            return _hyllor[rad, kolumn];
        }
        set
        {
            if (rad < 0 || rad >= _hyllor.GetLength(0) || kolumn < 0 || kolumn >= _hyllor.GetLength(1))
            {
                throw new IndexOutOfRangeException("Index utanför gränserna för lagret.");
            }
            _hyllor[rad, kolumn] = value;
        }
    }
    public int AntalRader => _hyllor.GetLength(0);
    public int AntalKolumner => _hyllor.GetLength(1);
}
class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("12 2D-Matris");
        Console.Title = "12 2D-Matris";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        SektionsLager lager = new SektionsLager(3, 4);
        lager[0, 2] = "Reservankare";
        lager[2, 1] = "Nodraketer";
        for (int i = 0; i < lager.AntalRader; i++)
        {
            for (int j = 0; j < lager.AntalKolumner; j++)
            {
                Console.Write($"{lager[i, j],-15}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();


        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}