
using MarinSystem.Navigation;
using MarinSystem.Ekonomi;

namespace MarinSystem.Navigation
{
    class KursBeraknare
    {
        public void BeraknaKurs(string destination)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Beräknar kurs mot {destination}.");
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
namespace MarinSystem.Ekonomi
{
    class FakturaHanterare
    {
        // Uppgiften anger double, men decimal används eftersom belopp representerar pengar.
        public void SkapaHamnFaktura(string båtNamn, decimal belopp)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Skapar faktura för {båtNamn} med belopp {belopp:C}.");
            Console.WriteLine();
            Console.WriteLine($"Faktura skickad till {båtNamn}.");
            Console.ResetColor();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("05 MarinLogistik");
        Console.Title = "05 MarinLogistik";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        KursBeraknare kursBeraknare = new KursBeraknare();
        kursBeraknare.BeraknaKurs("Stockholm");
        FakturaHanterare fakturaHanterare = new FakturaHanterare();
        fakturaHanterare.SkapaHamnFaktura("Båt1", 1000.0m);

        Console.WriteLine();


        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}

