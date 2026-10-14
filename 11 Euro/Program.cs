using System;

namespace Röda_uppgifter_11_Euro
{
    public class Euro
    {
        public decimal Belopp
        {
            get; set;
        }

        // Bekväm konstruktor
        public Euro(decimal belopp) => Belopp = belopp;

        // Parameterlös konstruktor behövs för objektinitierare om man vill använda "new Euro { ... }"
        public Euro()
        {
        }

        // Operatoröverlagring: Euro + Euro -> Euro
        public static Euro operator +(Euro e1, Euro e2)
        {
            return new Euro(e1.Belopp + e2.Belopp);
        }

        // Snygg utskrift
        public override string ToString() => $"{Belopp:F2} €";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region header
            Console.WriteLine("11 Euro – operator +");
            Console.Title = "11 Euro – operator +";
            Console.WriteLine("==========================");
            Console.WriteLine();
            #endregion

            // ---------- 1. Skapa två Euro-objekt ----------
            var e1 = new Euro(12.50m);
            var e2 = new Euro(7.75m);

            Console.WriteLine($"e1 = {e1}");
            Console.WriteLine($"e2 = {e2}");

            // ---------- 2. Addera direkt med + ----------
            Euro total = e1 + e2;
            Console.WriteLine($"\ne1 + e2 = {total}");

            // ---------- 3. Kedja flera additioner ----------
            var e3 = new Euro(0.99m);
            Euro summa = e1 + e2 + e3;
            Console.WriteLine($"\ne1 + e2 + e3 = {summa}");

            // ---------- 4. Originalen är oförändrade ----------
            Console.WriteLine($"\nOriginal e1 = {e1}  (oförändrad)");
            Console.WriteLine($"Original e2 = {e2}  (oförändrad)");

            #region footer
            Console.WriteLine("\n==========================");
            Console.WriteLine("\nTryck på en tangent för att avsluta...");
            Console.ReadKey();
            #endregion
        }
    }
}