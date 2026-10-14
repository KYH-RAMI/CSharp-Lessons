using System;

namespace Veckolista
{
    class Veckolista
    {
        private string[] veckodagar = new string[7]
        {
            "Måndag", "Tisdag", "Onsdag", "Torsdag", "Fredag", "Lördag", "Söndag"
        };

        // Indexerare
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= veckodagar.Length)
                    throw new IndexOutOfRangeException(
                        $"Index {index} är utanför intervallet 0–{veckodagar.Length - 1}.");

                return veckodagar[index];
            }
            set
            {
                if (index < 0 || index >= veckodagar.Length)
                    throw new IndexOutOfRangeException(
                        $"Index {index} är utanför intervallet 0–{veckodagar.Length - 1}.");

                veckodagar[index] = value;
            }
        }

        // Bekvämlighet: antal dagar
        public int Length => veckodagar.Length;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region header
            Console.WriteLine();
            Console.Title = "Veckolista";
            Console.WriteLine("==========================");
            Console.WriteLine();
            #endregion

            var lista = new Veckolista();

            // ---------- 1. Hämta dagar via index ----------
            Console.WriteLine("--- Hämta via index ---");
            Console.WriteLine($"lista[0] = {lista[0]}");   // Måndag
            Console.WriteLine($"lista[4] = {lista[4]}");   // Fredag
            Console.WriteLine($"lista[6] = {lista[6]}");   // Söndag

            // ---------- 2. Loopa igenom hela listan ----------
            Console.WriteLine("\n--- Alla dagar ---");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine($"{i}: {lista[i]}");
            }

            // ---------- 3. Ändra en dag via index ----------
            Console.WriteLine("\n--- Ändra via index ---");
            lista[5] = "Lördag (ledig!)";
            Console.WriteLine($"lista[5] = {lista[5]}");

            // ---------- 4. Felhantering ----------
            Console.WriteLine("\n--- Felhantering ---");
            try
            {
                Console.WriteLine(lista[10]);   // kastar undantag
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Fångat: {ex.Message}");
            }

            #region footer
            Console.WriteLine("\n==========================");
            Console.WriteLine("\nTryck på en tangent för att avsluta...");
            Console.ReadKey();
            #endregion
        }
    }
}