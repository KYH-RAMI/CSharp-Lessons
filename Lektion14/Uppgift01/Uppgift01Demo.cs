
namespace Lektion14.Uppgift01
{
    internal class Uppgift01Demo
    {
        public static void Kör()
        {
            Djur djur = new();
            Hund hund = new();
            Console.WriteLine("=== Uppgift 1: Virtuell metod – Djur och Hund ===");
            Console.WriteLine();

            Console.WriteLine("Djur:");
            djur.GörLjud();
            Console.WriteLine();
            Console.WriteLine("Hund:");
            hund.GörLjud();
            Console.WriteLine();


           
        }
    }
}
