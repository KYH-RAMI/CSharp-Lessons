#region header
Console.WriteLine("15 Rekursiv nedräkning");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

void RekursivNedräkning(int startVärde)
{
    if (startVärde == 0)
    {
        Console.WriteLine("BOOM!");
        return;
        
    }
    else
    {
        Console.WriteLine(startVärde);
        Thread.Sleep(200);

        RekursivNedräkning(startVärde - 1);
       
       
    }

}

RekursivNedräkning(10);

/*
 * Basfallet stoppar rekursionen när startVärde når 0.
 * Utan basfallet skulle metoden fortsätta anropa sig själv
 * och till slut orsaka en StackOverflowException. 
*/

#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion