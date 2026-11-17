using System;

namespace Record_Användare
{
    // ===== RECORD (C# 9+) – kort och koncis =====
    public record Anvandare(int Id, string Anvandarnamn);

    // ===== KLASS – för jämförelse =====
    public class AnvandareKlass
    {
        public int Id
        {
            get; init;
        }
        public string Anvandarnamn
        {
            get; init;
        }

        public AnvandareKlass(int id, string anvandarnamn)
        {
            Id = id;
            Anvandarnamn = anvandarnamn;
        }

        // Måste skrivas manuellt för att få samma fina utskrift!
        public override string ToString()
            => $"AnvandareKlass {{ Id = {Id}, Anvandarnamn = {Anvandarnamn} }}";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region header
            Console.WriteLine("05 Record – Användare");
            Console.Title = "05 Record – Användare";
            Console.WriteLine("==========================");
            Console.WriteLine();
            #endregion

            // ---------- 1. Skapa en record-instans ----------
            var a1 = new Anvandare(1, "alice");
            Console.WriteLine($"Record:        {a1}");

            // ---------- 2. Jämför med en vanlig klass ----------
            var k1 = new AnvandareKlass(1, "alice");
            Console.WriteLine($"Klass:         {k1}");

            // ---------- 3. Utskrift av enskilda egenskaper ----------
            Console.WriteLine($"\nId:            {a1.Id}");
            Console.WriteLine($"Användarnamn:  {a1.Anvandarnamn}");

            // ---------- 4. Värde-baserad likhet (record!) ----------
            var a2 = new Anvandare(1, "alice");
            var a3 = new Anvandare(2, "bob");

            Console.WriteLine($"\na1 == a2 ?     {a1 == a2}");   // True
            Console.WriteLine($"a1 == a3 ?     {a1 == a3}");   // False

            // ---------- 5. "with" – skapa en kopia med ändring ----------
            var a4 = a1 with
            {
                Anvandarnamn = "alice2"
            };
            Console.WriteLine($"\nKopia (with):  {a4}");
            Console.WriteLine($"Original:      {a1}");

            #region footer
            Console.WriteLine("\n==========================");
            Console.WriteLine("\nTryck på en tangent för att avsluta...");
            Console.ReadKey();
            #endregion
        }
    }
}