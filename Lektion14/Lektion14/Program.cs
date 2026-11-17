using Lektion14.Uppgift01;
using Lektion14.Uppgift02;
using Lektion14.Uppgift03;
using Lektion14.Uppgift04;
using Lektion14.Uppgift05;
using Lektion14.Uppgift06;
using Lektion14.Uppgift07;
using Lektion14.Uppgift08;
using Lektion14.Uppgift09;
using Lektion14.Uppgift10;
using Lektion14.Uppgift11;
using Lektion14.Uppgift12;
using Lektion14.Uppgift13;
using Lektion14.Uppgift14;
using Lektion14.Uppgift15;

namespace Lektion14;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Lektion 14 - OOP del 2";

        bool avsluta = false;

        while (!avsluta)
        {
            Console.Clear();

            Console.WriteLine("===== LEKTION 14 - OOP del 2 =====");
            Console.WriteLine();
            Console.WriteLine("1. Virtuell metod – Djur och Hund");
            Console.WriteLine();
            Console.WriteLine("2. Polymorfism med basklassreferens");
            Console.WriteLine();
            Console.WriteLine("3. Array av polymorfa objekt");
            Console.WriteLine();
            Console.WriteLine("4. Typkontroll och typomvandling (is och as)");
            Console.WriteLine();
            Console.WriteLine("5. Statisk polymorfism – Metodöverlagring");
            Console.WriteLine();
            Console.WriteLine("6. Verklig hierarki – Betalsystem");
            Console.WriteLine();
            Console.WriteLine("7. Verklig hierarki – Användarsystem");
            Console.WriteLine();
            Console.WriteLine("8. Try-Catch – Division med noll");
            Console.WriteLine();
            Console.WriteLine("9. FormatException och finally");
            Console.WriteLine();
            Console.WriteLine("10. Kasta egna undantag – ArgumentException");
            Console.WriteLine();
            Console.WriteLine("11. Egen undantagsklass – SaldoSaknasException");
            Console.WriteLine();
            Console.WriteLine("12. Tillämpa det egna undantaget");
            Console.WriteLine();
            Console.WriteLine("13. Stark sammanhållning – High Cohesion");
            Console.WriteLine();
            Console.WriteLine("14. Lös koppling via Interface");
            Console.WriteLine();
            Console.WriteLine("15. Flexibel arkitektur – Loose Coupling");
            Console.WriteLine();
            Console.WriteLine("0. Avsluta");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Välj uppgift: ");

            string? val = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            switch (val)
            {
                case "1":
                    Uppgift01Demo.Kör();
                    break;

                case "2":
                    Uppgift02Demo.Kör();
                    break;

                case "3":
                    Uppgift03Demo.Kör();
                    break;

                case "4":
                    Uppgift04Demo.Kör();
                    break;
                case "5":
                    Uppgift05Demo.Kör();
                    break;
                case "6":
                    Uppgift06Demo.Kör();
                    break;
                case "7":
                    Uppgift07Demo.Kör();
                    break;
                case "8":
                    Uppgift08Demo.Kör();
                    break;
                case "9":
                    Uppgift09Demo.Kör();
                    break;
                case "10":
                    Uppgift10Demo.Kör();
                    break;
                case "11":
                    Uppgift11Demo.Kör();
                    break;
                case "12":
                    Uppgift12Demo.Kör();
                    break;
                case "13":
                    Uppgift13Demo.Kör();
                    break;
                case "14":
                    Uppgift14Demo.Kör();
                    break;
                case "15":
                    Uppgift15Demo.Kör();
                    break;
                case "0":
                    avsluta = true;
                    break;
                default:
                    Console.WriteLine("Ogiltigt val!");
                    break;
            }

            if (!avsluta)
            {
                Console.WriteLine();
                Console.WriteLine("Tryck på valfri tangent för att återgå...");
                Console.ReadKey(true);
            }
        }

        Console.WriteLine("Programmet avslutas...");
    }
}