
namespace Lektion14.Uppgift05
{
    internal class Uppgift05Demo
    {
        public static void Kör()
        {
            Skrivare skrivare = new();
            Console.WriteLine("=== Uppgift 5: Statisk polymorfism – Metodöverlagring ===");
            Console.WriteLine();
            skrivare.SkrivUt("123"); // Anropar SkrivUt(string text)
            skrivare.SkrivUt(123);   // Anropar SkrivUt(int tal)

        }
    }
}
