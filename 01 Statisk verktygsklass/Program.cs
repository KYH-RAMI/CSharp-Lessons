
namespace _01_Statisk_verktygsklass
{


    public static class MatematikVerktyg
    {
        public static int HittaStorstaTal(int tal1, int tal2)
        {
            return tal1 > tal2 ? tal1 : tal2;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region header
            Console.WriteLine("");
            Console.Title = "";
            Console.WriteLine("==========================");
            Console.WriteLine();
            #endregion

            int störst = MatematikVerktyg.HittaStorstaTal(10, 20);
            Console.WriteLine($"Största talet är {störst}");

            #region footer
            Console.WriteLine("\n\n==========================");
            Console.WriteLine("\nTryck på en tangent för att avsluta...");
            Console.ReadKey();
            #endregion
        }

    }
}