using Lektion13.Uppgift01;
using Lektion13.Uppgift02;
using Lektion13.Uppgift03;
using Lektion13.Uppgift04;
using Lektion13.Uppgift05;
using Lektion13.Uppgift06;
using Lektion13.Uppgift07;
using Lektion13.Uppgift08;
using Lektion13.Uppgift09;
using Lektion13.Uppgift10;
using Lektion13.Uppgift11;
using Lektion13.Uppgift12;
using Lektion13.Uppgift13;
using Lektion13.Uppgift14;
using Lektion13.Uppgift15;

namespace Lektion13;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Title = "OOP - Lektion 13";

        bool avsluta = false;

        while (!avsluta)
        {
            Console.Clear();

            Console.WriteLine("===== OOP LEKTION 13 =====");
            Console.WriteLine();
            Console.WriteLine("1. Fordon och Bil");
            Console.WriteLine();
            Console.WriteLine("2. Djur och Katt");
            Console.WriteLine();
            Console.WriteLine("3. VD > Manager > Anställd");
            Console.WriteLine();
            Console.WriteLine("4. Sparkonto");
            Console.WriteLine();
            Console.WriteLine("5. SystemModul");
            Console.WriteLine();
            Console.WriteLine("6. AnvändarProfil");
            Console.WriteLine();
            Console.WriteLine("7. SpelKaraktär");
            Console.WriteLine();
            Console.WriteLine("8. Abstrakta klasser");
            Console.WriteLine();
            Console.WriteLine("9. Abstraktion och override");
            Console.WriteLine();
            Console.WriteLine("10. Flera abstrakta underklasser");
            Console.WriteLine();
            Console.WriteLine("11. Enkel interface gränssnitt (ILaddbar)");
            Console.WriteLine();
            Console.WriteLine("12. Implementera ett gränssnitt");
            Console.WriteLine();
            Console.WriteLine("13. Flera klasser, samma gränssnitt");
            Console.WriteLine();
            Console.WriteLine("14. Kombinera flera gränssnitt");
            Console.WriteLine();
            Console.WriteLine("15. Kombinera gränssnitt och abstrakta klasser");
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