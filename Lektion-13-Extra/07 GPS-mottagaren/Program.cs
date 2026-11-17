
interface IGpsMottagare
{
    (double latitud, double longitud) HämtaKoordinater();
}
interface ISändare
{
    void SändData();
}
class SjokortsPlotter : IGpsMottagare, ISändare
{
    public (double latitud, double longitud) HämtaKoordinater()
    => (59.3293, 18.0686); // Exempelkoordinater för Stockholm

    public void SändData()
        => Console.WriteLine("Data skickas från sjökortsplottern.");

}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("07 GPS-mottagaren (Gränssnittsmultiplicitet)");
        Console.Title = "07 GPS-mottagaren (Gränssnittsmultiplicitet)";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        SjokortsPlotter sjokortsPlotter = new SjokortsPlotter();

        IGpsMottagare gps = sjokortsPlotter;
        ISändare sändare = sjokortsPlotter;

        (double latitud, double longitud) koordinater = gps.HämtaKoordinater();

        Console.WriteLine(
            $"Hämtade koordinater: Latitud = {koordinater.latitud}, Longitud = {koordinater.longitud}");

        sändare.SändData();

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}