#region header
Console.WriteLine("08 Betygskollen");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

int[] betyg = new int[5]
{
    50,
    65,
    70,
    80,
    100

};
int betygSumma = 0;
for (int i = 0; i < betyg.Length; i++)
{
    betygSumma += betyg[i];
}

    double medelvärde = (double)betygSumma / betyg.Length;

    Console.WriteLine($"Medelvärdet är: {medelvärde}");


#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion