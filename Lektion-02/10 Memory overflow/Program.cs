byte maxVärde = byte.MaxValue; // 255
int maxVärdeInt = int.MaxValue; // 2,147,483,647

Console.WriteLine($"Före overflow: {maxVärde}, {maxVärdeInt}");
maxVärde++; // Overflow, blir 0
maxVärdeInt++; // Overflow, blir -2,147,483,648
//maxVärde = maxvärde + 1;

Console.WriteLine($"Efter overflow: {maxVärde}, {maxVärdeInt}");



Console.WriteLine("\n\n\tTryck på en tangent för att stänga fönstret...");

Console.ReadKey();