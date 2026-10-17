
namespace Lektion13.Uppgift07
{
    internal class SpelKaraktär
    {
        public int Hälsa { get; private set; }
        public int MaxHälsa { get; private set; }

        public SpelKaraktär(int maxHälsa)
        {
            MaxHälsa = maxHälsa;
            Hälsa = maxHälsa;
        }

        public void TaSkada(int skada)
        {
            // 1. Avvisa ogiltig skada.
            if (skada < 0)
            {
                Console.WriteLine("Skadan får inte vara negativ!");
                return;
            }

            // 2. Begränsa skadan till återstående hälsa.
            int faktiskSkada = Math.Min(skada, Hälsa);

            // 3. Dra av skadan.
            Hälsa -= faktiskSkada;

            // 4. Visa resultatet.
            Console.WriteLine($"Du tog {faktiskSkada} skada.");
            Console.WriteLine($"Hälsa: {Hälsa}/{MaxHälsa}");

            // 5. Kontrollera om spelaren dog.
            if (Hälsa == 0)
            {
                Console.WriteLine("Game Over!");
                return;
            }
        }

    }
}
