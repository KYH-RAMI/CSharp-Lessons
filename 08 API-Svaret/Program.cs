
record ApiResponse<T>(bool IsSuccess, string ErrorMessage, T Data, string HamtatTidpunkt);
record VäderData(double Temperatur, double Vindhastighet);
record HamnStatus(string HamnNamn, bool ÄrFull);


class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("08 API-Svaret");
        Console.Title = "08 API-Svaret";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion
        ApiResponse<VäderData> lyckatVäderSvar =
            new ApiResponse<VäderData>(
                true,
                "",
                new VäderData(25.5, 10.2),
                "2026-10-02T12:00:00"
            );  
        ApiResponse<HamnStatus> misslyckatHamnSvar =
            new ApiResponse<HamnStatus>(
                false,
                "Servern är nere",
                new HamnStatus("", false),
                "2026-10-02T12:00:00"
            );
        Console.WriteLine(lyckatVäderSvar);
        Console.WriteLine();
        Console.WriteLine(misslyckatHamnSvar);


        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}