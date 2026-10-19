
namespace Lektion14.Uppgift10
{
    internal class Uppgift10Demo
    {
        public static void Kör()
        {
            Console.WriteLine("=== Uppgift 10: Kasta egna undantag – ArgumentException ===");
            Console.WriteLine();
            Person person = new()
            {
                Ålder = 25
            };
            try
            {
                person.Ålder = -5;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"ArgumentException: {ex.Message}");
            }
        }
    }
}