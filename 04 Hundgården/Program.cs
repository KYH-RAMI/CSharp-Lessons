using System;
using System.Collections.Generic;


class Hund
{
    public string Namn;

    public Hund(string namn)
    {
        Namn = namn;
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("04 Hundgården");
        Console.Title = "04 Hundgården";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Hund hund1 = new Hund("Sigge");
        Hund hund2 = new Hund("Hugo");
        Hund hund3 = new Hund("Dodoo");

        List<Hund> hundLista = new List<Hund>();
        hundLista.Add(hund1);
        hundLista.Add(hund2);
        hundLista.Add(hund3);


        Console.WriteLine("Hundgården har följande hundar: \n");
        foreach (var hund in hundLista)
        {
            Console.WriteLine(hund.Namn);
        }

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}