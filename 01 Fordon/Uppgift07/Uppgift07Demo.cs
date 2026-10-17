

namespace Lektion13.Uppgift07
{
    internal class Uppgift07Demo
    {

        public static void Kör()
        {
            SpelKaraktär spelare = new(100);

            Console.WriteLine("=== Uppgift 7: Skrivskyddad inkapsling ===");
            Console.WriteLine();

            while (spelare.Hälsa > 0)
            {
                Console.WriteLine("Tryck på valfri tangent för nästa attack...");
                Console.ReadKey(true);

                int rndSkada = Random.Shared.Next(10, 30);
                spelare.TaSkada(rndSkada);
            }
        }
    }
}
