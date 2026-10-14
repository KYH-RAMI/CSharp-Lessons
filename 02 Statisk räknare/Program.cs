using System;

namespace StatiskRaknare
{
    public class InstansRaknare
    {
        // Statiskt fält som delas av ALLA instanser
        public static int antalObjekt = 0;

        // Konstruktor – körs varje gång en ny instans skapas
        public InstansRaknare()
        {
            antalObjekt++;
        }

        // Statisk metod för att läsa av antalet
        public static void AntalObjekt()
        {
            Console.WriteLine($"Antal objekt: {antalObjekt}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region header
            Console.WriteLine("02 Statisk räknare");
            Console.Title = "02 Statisk räknare";
            Console.WriteLine("==========================");
            Console.WriteLine();
            #endregion

            // Innan några instanser har skapats
            InstansRaknare.AntalObjekt();

            var instans1 = new InstansRaknare();
            InstansRaknare.AntalObjekt();   // 1

            var instans2 = new InstansRaknare();
            InstansRaknare.AntalObjekt();   // 2

            var instans3 = new InstansRaknare();
            InstansRaknare.AntalObjekt();   // 3

            #region footer
            Console.WriteLine("\n==========================");
            Console.WriteLine("\nTryck på en tangent för att avsluta...");
            Console.ReadKey();
            #endregion
        }
    }
}