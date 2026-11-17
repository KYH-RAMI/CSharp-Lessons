/*
 * 
ReferenceEquals(a, b)
→ Är det exakt samma objekt i minnet?

a == b
→ Din egen regel för om två Behörighet ska räknas som lika

a.Equals(b)
→ Ska ge samma logiska resultat som ==

GetHashCode()
→ Måste följa samma likhetsregler
new Behörighet("Admin", 5);
new Behörighet("admin", 5);
Roll: Admin == admin   // ignorera stora/små bokstäver
SäkerhetsNivå: 5 == 5
*/

class Behörighet
{
    public string Roll { get; set; }
    public int SäkerhetsNivå { get; set; }
    public Behörighet(string roll, int säkerhetsNivå)
    {
        Roll = roll;
        SäkerhetsNivå = säkerhetsNivå;
    }
    public static bool operator ==(Behörighet b1, Behörighet b2)
    {
        if (ReferenceEquals(b1, b2)) return true;
        if (b1 is null || b2 is null) return false;
        return string.Equals(b1.Roll, b2.Roll, StringComparison.OrdinalIgnoreCase) &&
               b1.SäkerhetsNivå == b2.SäkerhetsNivå;
    }
    public static bool operator !=(Behörighet b1, Behörighet b2)
    {
        return !(b1 == b2);
    }
    public override bool Equals(object obj)
    {
        if (obj is Behörighet other)
        {
            return this == other;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(
            StringComparer.OrdinalIgnoreCase.GetHashCode(Roll),
            SäkerhetsNivå
        );
    }
}
class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("14 Avancerad Behörighetsmatchning");
        Console.Title = "14 Avancerad Behörighetsmatchning";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion  

        Behörighet behörighet1 = new Behörighet("Admin", 5);
        Behörighet behörighet2 = new Behörighet("admin", 5);
        Behörighet behörighet3 = new Behörighet("User", 3);
        Console.WriteLine($"Behörighet1 == Behörighet2: {behörighet1 == behörighet2}");
        Console.WriteLine($"Behörighet1 != Behörighet2: {behörighet1 != behörighet2}");
        Console.WriteLine($"Behörighet1 == Behörighet3: {behörighet1 == behörighet3}");
        Console.WriteLine($"Behörighet1 != Behörighet3: {behörighet1 != behörighet3}");
        Console.WriteLine();
        Console.WriteLine($"Behörighet1.Equals(Behörighet2): {behörighet1.Equals(behörighet2)}");
        Console.WriteLine($"Behörighet1.Equals(Behörighet3): {behörighet1.Equals(behörighet3)}");

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}