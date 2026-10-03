/*
abstract class
→ kan inte skapas direkt

abstract method
→ har ingen implementation i basklassen

override
→ underklassen måste/kan ge implementationen
*/

abstract class Djur
{
    public abstract void GörLjud();
}

class Hund : Djur
{
    public override void GörLjud()
    {
        Console.WriteLine("Voff!");
    }
}

class Katt : Djur
{
    public override void GörLjud()
    {
        Console.WriteLine("Mjao!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("03 Abstrakta Djuret");
        Console.Title = "03 Abstrakta Djuret";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        var djur = new List<Djur>
        {
            new Hund(),
            new Katt(),
            new Hund(),
            new Hund(),
            new Katt()
        };
        foreach (Djur d in djur)
        {
            d.GörLjud();
        }


        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}