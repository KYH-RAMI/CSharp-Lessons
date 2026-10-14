using System;
using System.Text;

namespace Valutaomvandling
{
    public class Sek
    {
        public decimal Belopp
        {
            get;
        }

        public Sek(decimal belopp) => Belopp = belopp;

        // Explicit konvertering: Sek -> Usd
        public static explicit operator Usd(Sek sek)
        {
            return new Usd(sek.Belopp / Vaxelkurs.UsdTillSek);
        }

        public override string ToString() => $"{Belopp:F2} SEK";
    }

    public class Usd
    {
        public decimal Belopp
        {
            get;
        }

        public Usd(decimal belopp) => Belopp = belopp;

        // Explicit konvertering: Usd -> Sek (för symmetri)
        public static explicit operator Sek(Usd usd)
        {
            return new Sek(usd.Belopp * Vaxelkurs.UsdTillSek);
        }

        public override string ToString() => $"{Belopp:F2} USD";
    }

    // Central plats för växelkursen
    public static class Vaxelkurs
    {
        // 1 USD = 10.50 SEK (exempel)
        public const decimal UsdTillSek = 10.50m;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Text.Encoding uTF8 = System.Text.Encoding.UTF8;
            Console.InputEncoding = uTF8;
            #region header
            Console.WriteLine();
            Console.Title = "Valutaomvandling";
            Console.WriteLine("==========================");
            Console.WriteLine();
            #endregion

            // Växelkurs i header
            Console.WriteLine($"Växelkurs: 1 USD = {Vaxelkurs.UsdTillSek} SEK\n");

            // ---------- 1. SEK -> USD ----------
            Sek kronor = new Sek(1050m);
            Usd dollar = (Usd)kronor;
            Console.WriteLine($"{kronor}  =  {dollar}");

            // ---------- 2. USD -> SEK ----------
            Usd hundraDollar = new Usd(100m);
            Sek tillbaka = (Sek)hundraDollar;
            Console.WriteLine($"{hundraDollar}   =  {tillbaka}");

            // ---------- 3. Direkt i uttryck ----------
            Sek pris = new Sek(250m);
            Usd prisIUsd = (Usd)pris;
            Console.WriteLine($"\nPris: {pris}  →  {prisIUsd}");

            // ---------- 4. Rundtur – kontroll att det stämmer ----------
            Sek ursprunglig = new Sek(500m);
            Usd mellan = (Usd)ursprunglig;
            Sek tillbaka2 = (Sek)mellan;
            Console.WriteLine($"\nRundtur: {ursprunglig}  →  {mellan}  →  {tillbaka2}");

            #region footer
            Console.WriteLine("\n==========================");
            Console.WriteLine("\nTryck på en tangent för att avsluta...");
            Console.ReadKey();
            #endregion
        }
    }
}