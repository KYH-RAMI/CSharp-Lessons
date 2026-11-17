
namespace Lektion14.Uppgift09
{
    internal class Uppgift09Demo
    {
        public static void Kör()
        {

            Console.WriteLine("=== Uppgift 9: FormatException och finally ===");
            Console.WriteLine();
            Console.Write("Ange ett heltal: ");
            try
            {
                int nummer = int.Parse(Console.ReadLine() ?? string.Empty);
                Console.WriteLine($"Du angav talet: {nummer}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Felaktigt format! Ange ett giltigt heltal.");
            }
            finally
            {
                Console.WriteLine("Körningen avslutad");
            }

        }
    }
}
