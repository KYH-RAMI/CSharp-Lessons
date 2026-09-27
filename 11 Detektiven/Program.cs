#region header
Console.WriteLine("11 Detektiven");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

string[] namn =
{
    "Kalle",
    "Rami",
    "Koko",
    "Kalle",
    "Bobo",
    "Rami",
    "RoRo"
};
bool DuplikatHittad = false;
for (int i = 0; i < namn.Length; i++)
{
    for (int j = i + 1; j < namn.Length; j++)
    {

        if (namn[i] == namn[j])
        {
            if (!DuplikatHittad)
            {
                Console.WriteLine("Duplikat hittad!");
                DuplikatHittad = true;
            }
            Console.WriteLine(namn[i]);
        }
       
    } 
    
}


#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion