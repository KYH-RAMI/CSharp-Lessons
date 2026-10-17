

using Lektion13.Uppgift11;
using Lektion13.Uppgift12;

namespace Lektion13.Uppgift13
{
    internal class Uppgift13Demo
    {

        public static void Kör()
        {
            Console.WriteLine("=== Uppgift 13: Flera klasser, samma gränssnitt ===");
            Console.WriteLine();

            ILaddbar elbil = new Elbil();
            elbil.Ladda();

            ILaddbar elbil2 = new Elbil();
            ILaddbar telefon = new Mobiltelefon();
            elbil2.Ladda();
            telefon.Ladda();

            List<ILaddbar> enheter = [elbil, elbil2, telefon];

            foreach (var enhet in enheter)
            {
                Console.WriteLine($"Objekttyp: {enhet.GetType().Name}");
                enhet.Ladda();
                Console.WriteLine();

            }
            //LINQ
            enheter.Where(e => e is not Elbil).ToList().ForEach(e => e.Ladda());

        }
    }
}
