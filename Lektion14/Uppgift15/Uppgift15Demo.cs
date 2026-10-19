
using Lektion14.Uppgift14;

namespace Lektion14.Uppgift15
{
    internal class Uppgift15Demo
    {
        public static void Kör()
        {
            Console.WriteLine("=== Uppgift 15: Flexibel arkitektur – Loose Coupling ===");
            Console.WriteLine();
            IMeddelandeTjänst tjänst = new EpostTjänst();
            Notifierare notifierare = new Notifierare(tjänst);
            notifierare.SkickaNotis("Hejsan!");
            IMeddelandeTjänst tjänst2 = new SmsTjänst();
            Notifierare sms = new Notifierare(tjänst2);
            sms.SkickaNotis("Hejsan!");
        }
    }
}
