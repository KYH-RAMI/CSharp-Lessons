using System;
using System.Collections.Generic;


class Bok
{
    public string Titel;
    public string Författare;
    public int sidantal;

    public Bok(string titel, string författare, int sidantal)
    {
        Titel = titel;
        Författare = författare;
        this.sidantal = sidantal;
    }

}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("01 Bokkortet");
        Console.Title = "01 Bokkortet";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        // Skapa bokobjekt
        Bok bok1 = new Bok("Berättelsen om Rami", "Rami Issa", 200);
        Bok bok2 = new Bok("Sagan om Koko och Bobo", "RoRo", 300);

        //Skapa en lista för att lagra böckerna
        List<Bok> böcker = new List<Bok>();
        böcker.Add(bok1);
        böcker.Add(bok2);

        //Visa information om böckerna
        Console.WriteLine("Boklista: \n");

        foreach (Bok bok in böcker)
        {
            Console.WriteLine($"Titel: {bok.Titel}");
            Console.WriteLine($"Författare {bok.Författare}");
            Console.WriteLine($"Sidantal: {bok.sidantal}");
            Console.WriteLine();

        }




        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion

    }
}