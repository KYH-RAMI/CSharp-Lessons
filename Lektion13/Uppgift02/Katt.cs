
namespace Lektion13.Uppgift02;

public class Katt(string namn) : Djur(namn)
{
    public override string ToString()
    {
        return $"Jag är en katt och heter {Namn}";
    }

}