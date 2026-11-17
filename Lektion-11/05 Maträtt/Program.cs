namespace Maträtt;

public enum MatKategori
{
    Kött,
    Fisk,
    vegetariskt
}

public class Maträtt
{
    public string Namn { get; set; }
    public MatKategori Kategori { get; set; }

}
internal class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("05 Maträtt");
        Console.Title = "05 Maträtt";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Maträtt mat = new Maträtt();
        mat.Namn = "Köttbullar";
        mat.Kategori = MatKategori.Kött;

        Console.WriteLine($"Maträtt: {mat.Namn} - Kategori: {mat.Kategori}");
    
        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}