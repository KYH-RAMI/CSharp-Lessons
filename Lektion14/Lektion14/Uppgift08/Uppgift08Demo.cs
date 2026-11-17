
namespace Lektion14.Uppgift08
{
    internal class Uppgift08Demo
    {
        public static void Kör()
        {

            Console.WriteLine("=== Uppgift 8: Try-Catch – Division med noll ===");
            Console.WriteLine();

            Console.Write("Ange första talet: ");

            if (!int.TryParse(Console.ReadLine(), out int tal1))
            {
                Console.WriteLine("[FEL] Du måste ange ett giltigt heltal!");
                return;
            }

            Console.Write("Ange andra talet: ");

            if (!int.TryParse(Console.ReadLine(), out int tal2))
            {
                Console.WriteLine("[FEL] Du måste ange ett giltigt heltal!");
                return;
            }

            try
            {
                int resultat = tal1 / tal2;
                Console.WriteLine($"Resultat: {resultat}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("[FEL] Du kan inte dividera med noll!");
            }

        }
    }
}
