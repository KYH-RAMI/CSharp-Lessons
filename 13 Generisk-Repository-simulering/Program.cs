using System;

namespace Generisk_Repository_Simulering
{
    public class DataLager<T>
    {
        private readonly T[] _data = new T[5];
        private int _antal = 0;      // antal sparade element

        // ---------- Spara ----------
        public void Spara(T element)
        {
            if (_antal >= _data.Length)
                throw new InvalidOperationException(
                    $"Lagret är fullt (max {_data.Length} element).");

            _data[_antal] = element;
            _antal++;
        }

        // ---------- Antal sparade element ----------
        public int Antal => _antal;

        // ---------- Indexerare ----------
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _antal)
                    throw new IndexOutOfRangeException(
                        $"Index {index} är utanför intervallet 0–{_antal - 1}.");

                return _data[index];
            }
            set
            {
                if (index < 0 || index >= _antal)
                    throw new IndexOutOfRangeException(
                        $"Index {index} är utanför intervallet 0–{_antal - 1}.");

                _data[index] = value;
            }
        }

        // ---------- Snygg utskrift ----------
        public override string ToString()
        {
            var delar = new string[_antal];
            for (int i = 0; i < _antal; i++)
                delar[i] = _data[i]?.ToString() ?? "null";

            return $"[{string.Join(", ", delar)}]";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region header
            Console.WriteLine("13 Generiskt DataLager");
            Console.Title = "13 Generiskt DataLager";
            Console.WriteLine("==========================");
            Console.WriteLine();
            #endregion

            // ---------- 1. DataLager<int> ----------
            var tal = new DataLager<int>();
            tal.Spara(10);
            tal.Spara(20);
            tal.Spara(30);

            Console.WriteLine($"tal[0] = {tal[0]}");
            Console.WriteLine($"tal[1] = {tal[1]}");
            Console.WriteLine($"tal[2] = {tal[2]}");
            Console.WriteLine($"Antal: {tal.Antal}");
            Console.WriteLine($"Hela lagret: {tal}");

            // ---------- 2. DataLager<string> ----------
            var namn = new DataLager<string>();
            namn.Spara("Alice");
            namn.Spara("Bob");
            namn.Spara("Cissi");

            Console.WriteLine($"\nnamn[0] = {namn[0]}");
            Console.WriteLine($"Hela lagret: {namn}");

            // ---------- 3. Ändra via indexeraren ----------
            namn[1] = "Bertil";
            Console.WriteLine($"\nEfter ändring: {namn}");

            // ---------- 4. Loopa igenom ----------
            Console.WriteLine("\n--- Alla namn ---");
            for (int i = 0; i < namn.Antal; i++)
                Console.WriteLine($"{i}: {namn[i]}");

            // ---------- 5. Felhantering ----------
            Console.WriteLine("\n--- Felhantering ---");
            try
            {
                Console.WriteLine(namn[10]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Fångat: {ex.Message}");
            }

            try
            {
                var fullt = new DataLager<int>();
                for (int i = 0; i < 6; i++)
                    fullt.Spara(i);
            }
            catch (InvalidOperationException ex)
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