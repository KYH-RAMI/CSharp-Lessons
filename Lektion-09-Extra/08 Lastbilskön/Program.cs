/*
Uppgift 8: Lastbilskon vid tullen (Varierande rader i Jagged Array)
. Koncept: Manipulation av Jagged Arrays ([] []).
. Beskrivning: Tullen har 2 kontrollstationer. Skapa en Jagged Array dar station 1 har en
kö på 3 lastbilar (lagra registreringsnummer som strängar) och station 2 har en kö på 2
lastbilar.
Krav:
Skriv ut alla registreringsnummer sorterade efter vilken station de står vid.
Simulera att den forsta lastbilen i station 1 blir fardig genom att flytta fram de resterande
bilarna (eller sätta den första till "Klar").
*/

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("08 Lastbilskön vid tullen");
        Console.Title = "08 Lastbilskön vid tullen";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        string[][] station = new string[2][]
        {
            new string[3] { "ABC123", "DEF456", "GHI789" },
            new string[2] { "JKL012", "MNO345" }
        };

        // Flytta kön i station 1
        for (int i = 0; i < station[0].Length - 1; i++)
        {
            station[0][i] = station[0][i + 1];
        }

        station[0][station[0].Length - 1] = "Tom";

        Console.WriteLine("Registreringsnummer sorterade efter station: \n");

        for (int i = 0; i < station.Length; i++)
        {
            Console.WriteLine($"Station {i + 1}:");

            for (int j = 0; j < station[i].Length; j++)
            {
                Console.WriteLine(station[i][j]);
            }

            Console.WriteLine();
        }
        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}






