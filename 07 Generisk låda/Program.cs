using System;

namespace GeneriskLåda
{
    // ===== Generisk klass – kan hålla vilken typ som helst =====
    public class Låda<T>  // <T> betyder att det är en generisk klass
    {
        // Egenskap för att komma åt värdet
        public T Value
        {
            get; private set;
        }

        // Lägg till ett värde i lådan
        public void LaggTill(T value)
        {
            Value = value;
        }

        // Hämta ut värdet
        public T HittaUt()
        {
            return Value;
        }

        // Snygg utskrift
        public override string ToString()
            => $"Lada<{typeof(T).Name}> = {Value}";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region header
            Console.WriteLine("07 Generisk låda");
            Console.Title = "07 Generisk låda";
            Console.WriteLine("==========================");
            Console.WriteLine();
            #endregion

            // ---------- 1. Låda med int ----------
            var intLada = new Låda<int>();
            intLada.LaggTill(42);
            Console.WriteLine($"int:    {intLada.HittaUt()}");        // 42

            // ---------- 2. Låda med string ----------
            var stringLada = new Låda<string>();
            stringLada.LaggTill("Hej världen");
            Console.WriteLine($"string: {stringLada.HittaUt()}");     // Hej världen

            // ---------- 3. Låda med en egen klass ----------
            var personLada = new Låda<Person>();
            personLada.LaggTill(new Person("Alice", 30));
            Console.WriteLine($"Person: {personLada.HittaUt()}");

            // ---------- 4. Låda med double ----------
            var doubleLada = new Låda<double>();
            doubleLada.LaggTill(3.14);
            Console.WriteLine($"double: {doubleLada.HittaUt()}");

            #region footer
            Console.WriteLine("\n==========================");
            Console.WriteLine("\nTryck på en tangent för att avsluta...");
            Console.ReadKey();
            #endregion
        }
    }

    // Hjälpklass för demonstration
    public class Person
    {
        public string Namn
        {
            get;
        }
        public int Alder
        {
            get;
        }

        public Person(string namn, int alder)
        {
            Namn = namn;
            Alder = alder;
        }

        public override string ToString() => $"{Namn} ({Alder} år)";
    }
}