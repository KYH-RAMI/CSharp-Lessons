
using Lektion14.Uppgift14;

namespace Lektion14.Uppgift15
{
    internal class SmsTjänst : IMeddelandeTjänst
    {
        public void Skicka(string meddelande)
        {
            Console.WriteLine($"SMS skickat: {meddelande}");
        }
    }
}
