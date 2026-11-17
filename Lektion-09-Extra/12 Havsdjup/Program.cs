/*
 * Uppgift 12: Havsdjups-analysatorn (Grannceller och logik)
. Koncept: Logik kring intilliggande celler i en matris.
· Beskrivning: En djupskanning av ett havsområde lagras i en int [, ] på 4x4 celler, där
varje siffra anger djupet i meter.
. Krav:
o Skriv en metod som letar efter "grund" (celler dar djupet ar mindre an 5 meter).
o När ett grund hittas ska programmet varna och kontrollera om den direkt efterföljande
cellen på samma rad också är ett grund.
 * */


class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("12 Havsdjup-analysatorn");
        Console.Title = "12 Havsdjup-analysatorn";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        int[,] djup =
        {
            { 12, 8, 3, 2 },
            { 15, 6, 7, 10 },
            { 4, 3, 9, 11 },
            { 20, 18, 2, 6 }
        };
        KontrolleraGrund(djup);

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }
    static void KontrolleraGrund(int[,] djup)
    {
        for (int rad = 0; rad < djup.GetLength(0); rad++)
        {
            for (int kolumn = 0; kolumn < djup.GetLength(1); kolumn++)
            {
                if (djup[rad, kolumn] < 5)
                {
                    Console.WriteLine($"Varning! Grund på rad {rad}, kolumn {kolumn}.");

                    if (kolumn + 1 < djup.GetLength(1))
                    {
                        if (djup[rad, kolumn + 1] < 5)
                        {
                            Console.WriteLine("Nästa cell på samma rad är också grund!");
                        }
                    }
                }
            }
        }
    }
}


