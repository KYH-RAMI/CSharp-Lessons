
abstract class Kryptering
{
    public abstract string KrypteraText(string klartext);
}
class SkiftKryptering : Kryptering
{
    public override string KrypteraText(string klartext)
    {
        char[] tecken = klartext.ToCharArray();

        for (int i = 0; i < tecken.Length; i++)
        {
            if (tecken[i] != ' ')
            {
                tecken[i] = (char)(tecken[i] + 1);
            }
        }

        return new string(tecken);
    }
}
class OmvändKryptering : Kryptering
{
    public override string KrypteraText(string klartext)
    {
        // Implement reverse cipher logic here
        return new string(klartext.Reverse().ToArray());
    }
}
static class KrypteringsFabrik
{
    public static Kryptering SkapaKryptering(string typ)
    {
        return typ switch
        {
            "skift" => new SkiftKryptering(),
            "omvänd" => new OmvändKryptering(),
            _ => throw new ArgumentException("Ogiltig krypteringstyp")
        };
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("14 Den säkra fabrikshierarkin");
        Console.Title = "14 Den säkra fabrikshierarkin";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        string klartext = "Hej världen";

        Kryptering skift = KrypteringsFabrik.SkapaKryptering("skift");
        Kryptering omvänd = KrypteringsFabrik.SkapaKryptering("omvänd");

        Console.WriteLine($"Klartext: {klartext}");
        Console.WriteLine($"Skiftkryptering: {skift.KrypteraText(klartext)}");
        Console.WriteLine($"Omvänd kryptering: {omvänd.KrypteraText(klartext)}");



        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}