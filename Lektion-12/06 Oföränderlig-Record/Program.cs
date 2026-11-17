using System;

namespace Uppgift6
{
    // Oföränderlig record – egenskaperna är init-only
    public record ProduktRecord(string Produktnamn, int Pris);

    internal class Program
    {
        static void Main(string[] args)
        {
            #region header
            Console.WriteLine("06 Record med with-uttryck");
            Console.Title = "06 Record med with-uttryck";
            Console.WriteLine("==========================");
            Console.WriteLine();
            #endregion

            // ---------- 1. Skapa originalprodukten ----------
            var original = new ProduktRecord("Kaffe", 49);
            Console.WriteLine($"Original:  {original}");

            // ---------- 2. Skapa en kopia med ändrat pris via with ----------
            var dyrare = original with
            {
                Pris = 79
            };
            Console.WriteLine($"Kopia:     {dyrare}");

            // ---------- 3. Verifiera att originalet är oförändrat ----------
            Console.WriteLine($"\nOriginal efter with: {original}");
            Console.WriteLine($"Samma pris som innan? {original.Pris == 49}");

            // ---------- 4. Extra: två fält ändras samtidigt ----------
            var annan = original with
            {
                Produktnamn = "Te",
                Pris = 39
            };
            Console.WriteLine($"\nAnnan:     {annan}");

            // ---------- 5. Värde-likhet demonstreras ----------
            var kopia = original with
            {
            };
            Console.WriteLine($"\noriginal == kopia ?  {original == kopia}");   // True
            Console.WriteLine($"original == dyrare ? {original == dyrare}");  // False

            #region footer
            Console.WriteLine("\n==========================");
            Console.WriteLine("\nTryck på en tangent för att avsluta...");
            Console.ReadKey();
            #endregion
        }
    }
}