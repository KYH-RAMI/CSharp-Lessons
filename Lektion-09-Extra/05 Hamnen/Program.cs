
class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("05 Hamnen");
        Console.Title = "05 Hamnen";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        string[][] Brygga = new string[3][];
        Brygga[0] = new string[3];
        Brygga[1] = new string[5];
        Brygga[2] = new string[2];

        for(int i = 0; i < Brygga.Length; i++)
        {
            for(int j = 0; j < Brygga[i].Length; j++)
            {
                Brygga[i][j] = "Tom";

            }
        }
        int antalPlatser = 0;
        for (int i = 0; i < Brygga.Length; i++)
        {
            for (int j = 0; j < Brygga[i].Length; j++)
            {
                antalPlatser++;

            }
        }
        Console.WriteLine("Antal platser: " + antalPlatser);
        Console.WriteLine("Brygga 1: " + Brygga[0].Length);
        Console.WriteLine("Brygga 2: " + Brygga[1].Length);
        Console.WriteLine("Brygga 3: " + Brygga[2].Length);



        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}