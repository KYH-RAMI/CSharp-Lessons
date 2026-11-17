
class Bil
{
    private int _matarstallning;
    public int Mätarstallning
    {
        get => _matarstallning;

        set
        {
            if (value >= _matarstallning)
            {
                _matarstallning = value;

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fel: Mätarställningen kan inte sänkas!");
                Console.ResetColor();

            }
        }
    }

    public Bil(int matarstallning)
    {
        Mätarstallning = matarstallning;
    }

}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("07 Bil (Mätarställning)");
        Console.Title = "07 Bil (Mätarställning)";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        //anropa klassen Bil och skicka med mätarställning
        Bil bil = new Bil(10000);
        //Dubbelkolla mätarställniing innan manipulering
        Console.WriteLine($"Mätarställning: {bil.Mätarstallning} km");

        //  Ändra mätarställning till 12000 km (ökning)
        bil.Mätarstallning = 12000;
        Console.WriteLine($"Mätarställning: {bil.Mätarstallning} km");

        //  Ändra mätarställning till 8000 km  (förminskning)
        bil.Mätarstallning = 8000;
        Console.WriteLine($"Mätarställning: {bil.Mätarstallning} km");







        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}