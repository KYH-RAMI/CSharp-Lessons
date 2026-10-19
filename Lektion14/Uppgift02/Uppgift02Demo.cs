

using Lektion14.Uppgift01;

namespace Lektion14.Uppgift02
{
    internal class Uppgift02Demo
    {
        public static void Kör()
        {
            // Basklassreferens till ett Hund-objekt.
            // Tack vare virtual/override körs Hund.GörLjud().
            Djur hund = new Hund();
            Console.WriteLine("=== Uppgift 2: Polymorfism med basklassreferens ===");
            Console.WriteLine();
            Console.WriteLine("Hund:");
            hund.GörLjud();
            Console.WriteLine($"Objekttyp: {hund.GetType().Name}");
        }
    }
}

