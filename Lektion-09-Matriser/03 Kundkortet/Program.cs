using System;
using System.Collections.Generic;


class Kund
{
    public string Namn;
    public string Epost;
    public string Medlemsnivå = "Brons";

    public Kund(string namn, string epost)
    {
        Namn = namn;
        Epost = epost;
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("03 Kundkortet");
        Console.Title = "03 Kundkortet";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

       Kund kund1 = new Kund("Ola", "ola@ola.se");
       Kund kund2 = new Kund("Kalle", "kalle@kalle.se");

        List<Kund> KundLista = new List<Kund>();
        KundLista.Add(kund1);
        KundLista.Add(kund2);

        foreach (Kund kund in KundLista)
        {
            Console.WriteLine($"Namn: {kund.Namn} ");
            Console.WriteLine($"Epost: {kund.Epost} ");
            Console.WriteLine($"Medlemsnivå: {kund.Medlemsnivå} ");
            Console.WriteLine("\n");
        }


        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}