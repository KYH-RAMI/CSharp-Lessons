
using Lektion14.Uppgift11;

namespace Lektion14.Uppgift12
{
    internal class Bankkonto
    {
        private decimal _saldo;
        public decimal Saldo => _saldo;
        public Bankkonto(decimal startsaldo) => this._saldo = startsaldo;

        public void Uttag(decimal belopp)
        {
            if (belopp <= 0)
            {
                throw new ArgumentException("Beloppet måste vara större än noll", nameof(belopp));
            }

            if (belopp > _saldo)
            {
                throw new SaldoSaknasException("Beloppet är större än balansen");
            }
            this._saldo -= belopp;
        }
    }
}