
namespace Lektion14.Uppgift14
{
    internal class EpostTjänst : IMeddelandeTjänst
    {
        public void Skicka(string meddelande)
        {
            Console.WriteLine($"E-post skickad: {meddelande}");
        }
    }
}
