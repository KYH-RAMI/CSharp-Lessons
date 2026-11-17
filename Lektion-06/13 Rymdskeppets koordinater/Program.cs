Console.WriteLine("13 Rymdskeppets koordinater");
Console.WriteLine("==========================");
Console.WriteLine();

Console.Write("Ange koordinator X (1-5): ");
string inputX = Console.ReadLine();
int numberX = 0;
Console.Write("Ange koordinator Y (1-5): ");
string inputY = Console.ReadLine();
int numberY = 0;

if (int.TryParse(inputX, out numberX) && int.TryParse(inputY, out numberY))
{
    Console.WriteLine();
    if (numberX >= 1 && numberX <= 5 && numberY >= 1 && numberY <= 5)
    {
        for (int y = 1; y <= 5; y++)
        {

            for (int x = 1; x <= 5; x++)
            {


                if (x == numberX && y == numberY)
                {
                    Console.Write("S");
                }
                else
                {
                    Console.Write(".");
                }

            }
            Console.WriteLine();

        }
    }
    else
    {
        Console.WriteLine("\n\nDu försöker mata in ett heltal som inte var inom området 1-5\n\n");
    }
    Console.WriteLine();
}
else
{
    Console.WriteLine("\n\nDet du matade in är inte ett giltigt heltal.\n\n");
}

Console.WriteLine("==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();


