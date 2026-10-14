using System;

namespace Struktur_2D_punkt
{
    // ===== STRUKTUR (värdetyp) =====
    struct Punkt2D
    {
        public int X;
        public int Y;

        public Punkt2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"({X}, {Y})";
    }

    // ===== KLASS (referenstyp) – för jämförelse =====
    class Punkt2DKlass
    {
        public int X;
        public int Y;

        public Punkt2DKlass(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"({X}, {Y})";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region header
            Console.WriteLine();
            Console.Title = "Punkt2D – struct vs class";
            Console.WriteLine("==========================");
            Console.WriteLine();
            #endregion

            // ---------- 1. Struktur = värdetyp ----------
            Console.WriteLine("--- STRUKTUR (värdetyp) ---");
            Punkt2D p1 = new Punkt2D(1, 2);
            Punkt2D p2 = p1;          // KOPIERAR värdet

            p2.X = 99;                // ändrar bara p2
            p2.Y = 99;

            Console.WriteLine($"p1 = {p1}");   // (1, 2)  – oförändrad
            Console.WriteLine($"p2 = {p2}");   // (99, 99)

            // ---------- 2. Klass = referenstyp ----------
            Console.WriteLine("\n--- KLASS (referenstyp) ---");
            Punkt2DKlass k1 = new Punkt2DKlass(1, 2);
            Punkt2DKlass k2 = k1;     // KOPIERAR referensen

            k2.X = 99;                // ändrar SAMMA objekt
            k2.Y = 99;

            Console.WriteLine($"k1 = {k1}");   // (99, 99) – påverkad!
            Console.WriteLine($"k2 = {k2}");   // (99, 99)

            #region footer
            Console.WriteLine("\n==========================");
            Console.WriteLine("\nTryck på en tangent för att avsluta...");
            Console.ReadKey();
            #endregion
        }
    }
}