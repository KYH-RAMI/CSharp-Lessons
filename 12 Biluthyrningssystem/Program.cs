
namespace Biluthyrningssystem
{

    public class Hyrbil
    {
        public string Registreringsnummer
        {
            get; set;
        }
        public bool ArTillganglig
        {
            get; set;
        }
    }
    public class Kund
    {
        public string Namn
        {
            get; set;
        }
    }
    public class Uthyrning
    {
        public Hyrbil Bil
        {
            get; set;
        }
        public Kund Kund
        {
            get; set;
        }
        public void GenomforUthyrning()
        {
            if (Bil.ArTillganglig)
            {
                Bil.ArTillganglig = false;
                Console.WriteLine($"Bilen {Bil.Registreringsnummer} har hyrts ut till {Kund.Namn}.");
            }
            else
            {
                Console.WriteLine($"Bilen {Bil.Registreringsnummer} är redan uthyrd.");
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region header
            Console.WriteLine("12 Biluthyrningsystem");
            Console.Title = "12 Biluthyrningsystem";
            Console.WriteLine("==========================");
            Console.WriteLine();
            #endregion

            Hyrbil bil = new Hyrbil();
            bil.Registreringsnummer = "ABC123";
            bil.ArTillganglig = true;

            Kund kund = new Kund();
            kund.Namn = "Kalle";

            Uthyrning uthyrning = new Uthyrning();
            uthyrning.Bil = bil;
            uthyrning.Kund = kund;

            uthyrning.GenomforUthyrning();

            #region footer
            Console.WriteLine("\n\n==========================");
            Console.WriteLine("\nTryck på en tangent för att avsluta...");
            Console.ReadKey();
            #endregion
        }

    }
}