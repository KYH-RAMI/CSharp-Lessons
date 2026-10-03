/*
DelMål
→ record
→ beskriver ett mål med Namn + Distans

RuttPlanerare<T>
→ generic
→ kan egentligen lagra vilken typ som helst

List<T>
→ håller alla målen internt

ruttPlanerare[1]
→ indexerare
→ ger direkt åtkomst till element nummer 2
*/

record DelMål(string Namn, double Distans);
class RuttPlanerare<T>
{
    private readonly List<T> _delMål = new List<T>();
    public int TotaltAntalMål => _delMål.Count;
    public T this[int index]
    {
        get => _delMål[index];
        set => _delMål[index] = value;
    }
    
    public void LäggTillMål(T mål)
    {
        _delMål.Add(mål);
    }

}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("15 Ruttplaneringssystemet");
        Console.Title = "15 Ruttplaneringssystemet";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        RuttPlanerare<DelMål> ruttPlanerare = new RuttPlanerare<DelMål>();
        ruttPlanerare.LäggTillMål(new DelMål("Athen", 100));
        ruttPlanerare.LäggTillMål(new DelMål("Poros", 200));
        ruttPlanerare.LäggTillMål(new DelMål("Hydra", 300));

        Console.WriteLine("Delmål på rutten:");

        for (int i = 0; i < ruttPlanerare.TotaltAntalMål; i++)
        {
            Console.WriteLine($"  {i + 1}. {ruttPlanerare[i].Namn} - {ruttPlanerare[i].Distans} km");
        }
        Console.WriteLine($"\nDet andra delmålet är: {ruttPlanerare[1]}");

        Console.WriteLine("\nErsätter det andra delmålet med Aegina:");
        ruttPlanerare[1] = new DelMål("Aegina", 150);

        Console.WriteLine("\nDen slutgiltiga rutten:");
        for (int i = 0; i < ruttPlanerare.TotaltAntalMål; i++)
        {
            Console.WriteLine($"  {i + 1}. {ruttPlanerare[i].Namn} - {ruttPlanerare[i].Distans} km");

        }
        Console.WriteLine();

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}