/*
interface
→ beskriver VAD en klass måste kunna göra

class
→ bestämmer HUR det faktiskt görs
*/

interface INavigerbar
{
    void Navigera(string destination);
}

class Båt : INavigerbar
{
    public void Navigera(string destination)
    {
        Console.WriteLine($"Båten navigerar mot {destination}.");
    }
}



class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("04 Det marina gränssnittet");
        Console.Title = "04 Det marina gränssnittet";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Båt båt = new Båt();
        båt.Navigera("Stockholm");


        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}