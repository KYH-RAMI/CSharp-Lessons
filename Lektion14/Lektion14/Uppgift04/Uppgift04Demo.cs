using Lektion14.Uppgift01;
using Lektion14.Uppgift03;

namespace Lektion14.Uppgift04
{
    internal class Uppgift04Demo
    {
        public static void Kör()
        {
            Djur[] djuren = [new Hund(), new Katt()];
            Console.WriteLine("=== Uppgift 4: Typkontroll och typomvandling (is och as) ===");
            Console.WriteLine();
            Console.WriteLine("=== Test med IS ===");

            foreach (Djur djur in djuren)
            {
                djur.GörLjud();

                if (djur is Hund hund)
                {
                    hund.ViftaPåSvansen();
                }
            }

            Console.WriteLine();
            Console.WriteLine("=== Test med AS ===");

            foreach (Djur djur in djuren)
            {
                djur.GörLjud();
                Hund? hund = djur as Hund;

                if (hund is not null)
                {
                    hund.ViftaPåSvansen();
                }
            }
        }
    }
}
