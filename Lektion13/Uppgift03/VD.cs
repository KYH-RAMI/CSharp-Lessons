using System;
using System.Collections.Generic;
using System.Text;

namespace Lektion13.Uppgift03
{
    internal class VD : Manager
    {
        public string Företag { get; set; }
        
        public VD(string namn, string avdelning, string företag)
            : base(namn, avdelning)
        {
            Företag = företag;
        }

    }
}
