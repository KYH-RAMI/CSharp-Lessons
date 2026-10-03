/*
 * Uppgift 10: Meteorologiska Verktygslådan [GUL]
Koncept: Statiska medlemmar & Structs
Beskrivning: Kombinera en statisk verktygsklass med en lättvikts-struct för att utföra
enhetskonverteringar för vindhastigheter, vilket efterliknar inbyggda verktyg i .NET såsom 'Math'.

Instruktioner och krav:

>kyh>

· Skapa en 'struct VindData' som innehåller 'double Knop' och 'string Riktning' (t.ex. "NV").
· Skapa en statisk klass 'MeteoVerktyg'.
· Lägg till en statisk metod 'TillMeterPerSekund(VindData data)' i klassen som beräknar och
returnerar vindhastigheten i m/s (formel: knop * 0.51444).
. Lägg till en statisk metod 'ÄrKuling(VindData data)' som returnerar true om vinden overstiger
13.9 m/s (ca 27 knop).
· I Main: Skapa en 'VindData` på 30 knop från "SO". Använd din statiska klass för att räkna ut m/s
samt kontrollera om det klassas som kuling. Skriv ut resultaten.

*/

struct VindData
{
    public double Knop { get; set; }
    public string Riktning { get; set; }

    public VindData(double knop, string riktning)
    {
        Knop = knop;
        Riktning = riktning;
    }
}
static class MeteoVerktyg
{
    public static double TillMeterPerSekund(VindData data)
    {
        return data.Knop * 0.51444;
    }
    public static bool ÄrKuling(VindData data)
    {
        return TillMeterPerSekund(data) > 13.9;
    }
}


class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("10 Meteorologiska Verktygslådan");
        Console.Title = "10 Meteorologiska Verktygslådan";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        VindData vindData = new VindData(30, "SO");
        double mPerS = MeteoVerktyg.TillMeterPerSekund(vindData);
        bool kuling = MeteoVerktyg.ÄrKuling(vindData);


        if (kuling)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Vinden klassas som kuling.");
            Console.WriteLine($"Vindhastighet: {vindData.Knop} knop ({vindData.Riktning})");
            Console.WriteLine($"Vindhastighet i m/s: {mPerS}");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vinden klassas inte som kuling.");
            Console.WriteLine($"Vindhastighet: {vindData.Knop} knop ({vindData.Riktning})");
            Console.WriteLine($"Vindhastighet i m/s: {mPerS}");
            Console.ResetColor();
        }
        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}