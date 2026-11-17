
namespace Lektion14.Uppgift10
{
    internal class Person
    {
        private int _ålder;

        public int Ålder
        {
            get => _ålder;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Åldern kan inte vara negativ.", nameof(Ålder));
                }
                _ålder = value;
            }
        }


    }
}
