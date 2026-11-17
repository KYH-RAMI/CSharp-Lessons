
class Fartyg
{
    public string MmsiId { get; }
    public Fartyg(string mmsiId)
        => MmsiId = mmsiId;
}
class KommersielltFartyg : Fartyg
{
    public string Rederi { get; }
    public KommersielltFartyg(string mmsiId, string rederi)
        : base(mmsiId)
        => Rederi = rederi;
}
class ContainerFartyg : KommersielltFartyg
{
    public int MaxAntalContainers { get; }
    public ContainerFartyg(string mmsiId, string rederi, int maxAntalContainers)
        : base(mmsiId, rederi)
        => MaxAntalContainers = maxAntalContainers;
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("09 AIS-Mottagaren");
        Console.Title = "09 AIS-Mottagaren";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        ContainerFartyg fartyg =
           new ContainerFartyg(
               "265123456",
               "Maersk",
               18000);

        Console.WriteLine($"MMSI-ID: {fartyg.MmsiId}");
        Console.WriteLine($"Rederi: {fartyg.Rederi}");
        Console.WriteLine($"Max antal containers: {fartyg.MaxAntalContainers}");

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}