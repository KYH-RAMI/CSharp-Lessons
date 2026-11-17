
namespace Lektion14.Uppgift14
{
    internal class Uppgift14Demo
    {
        public static void Kör()
        {
            Console.WriteLine("=== Uppgift 14: Lös koppling via Interface ===");
            Console.WriteLine();
            IMeddelandeTjänst tjänst = new EpostTjänst();
            Notifierare notifierare = new Notifierare(tjänst);
            notifierare.SkickaNotis("Hejsan!");
        }
    }
}
