
namespace Lektion14.Uppgift07
{
    internal class Uppgift07Demo
    {
        public static void Kör()
        {

            Console.WriteLine("=== Uppgift 7: Verklig hierarki – Användarsystem ===");
            Console.WriteLine();
            List<Användare> användare = new()
            {
                 new Kund { Namn = "Izzy" },
                new Admin { Namn = "RoRo" },
                new Kund { Namn = "Gurre" },
                new Användare { Namn = "Hemlös användare!" }
            };

            foreach (var anv in användare)
            {
                
                anv.VisaInformation();
                if (anv is Admin admin)
                {
                    admin.NollställSystem();
                }
            }
        }
    }
}
