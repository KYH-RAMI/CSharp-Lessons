
namespace Produktlager
{
    public class LagerArtikel
    {
        private double _inkoppspris;
        private double _utpris;

        public LagerArtikel(double inkoppspris)
        {
            _inkoppspris = inkoppspris;
            _utpris = inkoppspris * 1.25;
        }

        public double Inkoppspris
        {
            get
            {
                return _inkoppspris;
            }
        }

        public double Utpris
        {
            get
            {
                return _utpris;
            }
            set
            {
                if (value < _inkoppspris * 1.25)
                {
                    _utpris = _inkoppspris * 1.25;
                }
                else
                {
                    _utpris = value;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region header
            Console.WriteLine("13 Produktlager");
            Console.Title = "13 Produktlager";
            Console.WriteLine("==========================");
            Console.WriteLine();
            #endregion

            LagerArtikel artikel = new LagerArtikel(100);

            Console.WriteLine($"Inköpspris: {artikel.Inkoppspris}");
            Console.WriteLine($"Utpris: {artikel.Utpris}");

            artikel.Utpris = 110;
            Console.WriteLine($"Utpris efter för lågt pris: {artikel.Utpris}");

            artikel.Utpris = 200;
            Console.WriteLine($"Utpris efter godkänt pris: {artikel.Utpris}");

            #region footer
            Console.WriteLine("\n\n==========================");
            Console.WriteLine("\nTryck på en tangent för att avsluta...");
            Console.ReadKey();
            #endregion
        }

    }
}
