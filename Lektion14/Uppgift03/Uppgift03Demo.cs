
using Lektion14.Uppgift01;

namespace Lektion14.Uppgift03
{
    internal class Uppgift03Demo
    {
        public static void Kör()
        {
            Djur[] djuren = [new Hund(), new Katt()];
            Console.WriteLine("=== Uppgift 3: Array av polymorfa objekt ===");
            Console.WriteLine();
            foreach (Djur djur in djuren)
            {
                djur.GörLjud();
            }
        }
    }
}
