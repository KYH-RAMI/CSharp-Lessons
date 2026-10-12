using System;

namespace Rektangel
{
    class Rektangel
    {
        public int Bredd
        {
            get; set;
        }
        public int Hojd
        {
            get; set;
        }
        public int Area => Bredd * Hojd;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region header
            Console.WriteLine("07 Rektangel");
            Console.Title = "07 Rektangel";
            Console.WriteLine("==========================");
            Console.WriteLine();
            #endregion

            Rektangel r1 = new Rektangel();
            r1.Bredd = 10;
            r1.Hojd = 20;
            Console.WriteLine($"Area av r1 är {r1.Area}");

            #region footer
            Console.WriteLine("\n\n==========================");
            Console.WriteLine("\nTryck på en tangent för att avsluta...");
            Console.ReadKey();
            #endregion
        }

    }
}