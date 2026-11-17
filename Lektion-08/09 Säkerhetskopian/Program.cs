#region header
Console.WriteLine("09 Säkerhetskopian");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

string[] IP = new string[4]
{
        "192.168.1.1",
        "192.168.1.2",
        "192.168.1.5",
        "192.168.1.8"
};

string[] nyIP = new string[IP.Length];
Console.WriteLine();
Console.WriteLine("IP Listan: ");
for (int i = 0; i < IP.Length; i++)
{
    Console.WriteLine(IP[i]);
}

// Array.Copy skapar inte samma array igen,
// utan kopierar elementen till en separat array.

Array.Copy(IP, nyIP, IP.Length);

IP[2] = "192.168.1.70";

Console.WriteLine();
Console.WriteLine("Gamla IP Listan med ändring: ");
for (int i = 0; i < IP.Length; i++)
{
    Console.WriteLine(IP[i]);
}
Console.WriteLine();
Console.WriteLine("Nya IP listan: ");
for (int i = 0; i < nyIP.Length; i++)
{
    Console.WriteLine(nyIP[i]);
}


#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion