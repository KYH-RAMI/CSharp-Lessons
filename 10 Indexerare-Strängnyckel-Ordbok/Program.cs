using System;

namespace IndexerareSträngnyckelOrdbok
{
    public class EnkelOrdbok
    {
        // Indexerare – tar svenskt ord, returnerar engelsk översättning
        public string this[string svensktOrd]
        {
            get
            {
                switch (svensktOrd)
                {
                    case "Hälsa":
                        return "Hello";
                    case "Bra":
                        return "Good";
                    case "Tack":
                        return "Thank you";
                    default:
                        return "Not found";
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region header
            Console.WriteLine("10 Enkel ordbok");
            Console.Title = "10 Enkel ordbok";
            Console.WriteLine("==========================");
            Console.WriteLine();
            #endregion

            // Skapa en instans av ordboken
            var ordbok = new EnkelOrdbok();

            // ---------- 1. Slå upp kända ord ----------
            Console.WriteLine($"Hälsa -> {ordbok["Hälsa"]}");
            Console.WriteLine($"Bra   -> {ordbok["Bra"]}");
            Console.WriteLine($"Tack  -> {ordbok["Tack"]}");

            // ---------- 2. Okänt ord ----------
            Console.WriteLine($"Hej   -> {ordbok["Hej"]}");

            // ---------- 3. Loopa genom en lista av ord ----------
            Console.WriteLine("\n--- Slå upp flera ord ---");
            string[] ord = { "Hälsa", "Tack", "Hej", "Bra" };
            foreach (var o in ord)
            {
                Console.WriteLine($"{o,-6} -> {ordbok[o]}");
            }

            #region footer
            Console.WriteLine("\n==========================");
            Console.WriteLine("\nTryck på en tangent för att avsluta...");
            Console.ReadKey();
            #endregion
        }
    }
}