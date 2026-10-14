using System;

namespace Tidsintervall
{
    public class Tidsintervall
    {
        public int Minuter
        {
            get; set;
        }

        public Tidsintervall(int minuter)
        {
            // Normalisera till intervallet [0, 1439] – ett dygn har 1440 minuter
            if (minuter < 0)
                Minuter = 0;
            else if (minuter >= 1440)
                Minuter = 0;   // 1440 och över → 0 (midnatt)
            else
                Minuter = minuter;
        }

        // ----- Operatorer -----
        public static bool operator >(Tidsintervall a, Tidsintervall b)
            => a.Minuter > b.Minuter;

        public static bool operator <(Tidsintervall a, Tidsintervall b)
            => a.Minuter < b.Minuter;

        // Trevligt att ha med:
        public static bool operator >=(Tidsintervall a, Tidsintervall b)
            => a.Minuter >= b.Minuter;

        public static bool operator <=(Tidsintervall a, Tidsintervall b)
            => a.Minuter <= b.Minuter;

        // Snygg utskrift som "HH:mm"
        public override string ToString()
            => $"{Minuter / 60:D2}:{Minuter % 60:D2}  ({Minuter} min)";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region header
            Console.WriteLine("12 Tidsintervall – jämförelseoperatorer");
            Console.Title = "12 Tidsintervall – jämförelseoperatorer";
            Console.WriteLine("==========================");
            Console.WriteLine();
            #endregion

            var morgon = new Tidsintervall(8 * 60);      // 08:00
            var kväll = new Tidsintervall(20 * 60);     // 20:00
            var samma = new Tidsintervall(8 * 60);      // 08:00 igen
            var midnatt = new Tidsintervall(0);

            Console.WriteLine($"morgon  = {morgon}");
            Console.WriteLine($"kväll   = {kväll}");
            Console.WriteLine($"samma   = {samma}");
            Console.WriteLine($"midnatt = {midnatt}");

            // ---------- 1. Använd operatorerna i if-satser ----------
            Console.WriteLine("\n--- Jämförelser ---");

            if (morgon < kväll)
                Console.WriteLine("morgon < kväll  →  sant");

            if (kväll > morgon)
                Console.WriteLine("kväll > morgon  →  sant");

            if (!(morgon > kväll))
                Console.WriteLine("morgon > kväll  →  falskt");

            if (morgon >= samma)
                Console.WriteLine("morgon >= samma →  sant (lika)");

            // ---------- 2. Felhantering / normalisering ----------
            Console.WriteLine("\n--- Normalisering ---");
            var negativ = new Tidsintervall(-50);
            var över = new Tidsintervall(1500);
            Console.WriteLine($"-50 min   blir {negativ}");
            Console.WriteLine($"1500 min  blir {över}");

            // ---------- 3. Sortera med operatorerna ----------
            Console.WriteLine("\n--- Sortering ---");
            var tider = new[]
            {
                new Tidsintervall(15 * 60),
                new Tidsintervall(3 * 60),
                new Tidsintervall(22 * 60),
                new Tidsintervall(0)
            };
            Array.Sort(tider, (a, b) => a < b ? -1 : (a > b ? 1 : 0));
            foreach (var t in tider)
                Console.WriteLine(t);

            #region footer
            Console.WriteLine("\n==========================");
            Console.WriteLine("\nTryck på en tangent för att avsluta...");
            Console.ReadKey();
            #endregion
        }
    }
}