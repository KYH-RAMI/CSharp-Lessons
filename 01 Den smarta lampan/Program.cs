
class SmartLamp
{
    public bool IsOn;
    public int Brightness;
    public SmartLamp()
    {
        IsOn = false;
        Brightness = 0;
    }
    public void Toggle()
    {
        IsOn = !IsOn;
        Console.WriteLine($"Lampan är nu {(IsOn ? "på" : "av")}.");
    }
    public void SetBrightness(int level)
    {
        if (level < 0 || level > 100)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ljusstyrkan måste vara mellan 0 och 100.");
            Console.ResetColor();
            return;
        }
        Brightness = level;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Ljusstyrkan är nu satt till {Brightness}%.");
        Console.ResetColor();  
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("01 Den Smarta Lampan");
        Console.Title = "01 Den Smarta Lampan";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

         var lamp = new SmartLamp();
        lamp.Toggle();
        lamp.SetBrightness(-50);
        lamp.Toggle();
        lamp.SetBrightness(101);
        lamp.Toggle();
        lamp.SetBrightness(0);
        lamp.Toggle();
        lamp.SetBrightness(50);

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}