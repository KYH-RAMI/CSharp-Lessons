using System;
using System.Collections.Generic;
using System.Text;

namespace Lektion13.Uppgift03
{
    internal class Manager : Anställd
    {
        public string Avdelning { get; set; }

        public Manager(string namn, string avdelning)
            : base(namn)
        {
            Avdelning = avdelning;
        }
    }
}
