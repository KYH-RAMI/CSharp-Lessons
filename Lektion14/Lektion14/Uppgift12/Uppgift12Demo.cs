
using Lektion14.Uppgift11;

namespace Lektion14.Uppgift12
{
    internal class Uppgift12Demo
    {
        public static void Kör()
        {
            Console.WriteLine("=== Uppgift 12: Tillämpa det egna undantaget ===");
            Console.WriteLine();
            Bankkonto konto = new Bankkonto(500);
            Console.WriteLine($"Bankkontots saldo: {konto.Saldo:C2}");
            Console.WriteLine("Genomför uttag på 350 kr");
            konto.Uttag(350m);
            Console.WriteLine($"Saldo efter transaktionen: {konto.Saldo:C2}");
            Console.WriteLine("Genomför uttag på 500 kr");
            try
            {
                konto.Uttag(500m);
            }
            catch (SaldoSaknasException ex)
            {
                Console.WriteLine($"Uttag nekades: {ex.Message}");
            }

        }
    }
}
