using System;
using System.Collections.Generic;
using System.Text;

namespace Scacchi
{
    public class Re : Pezzo
    {
        public Re(Colore schieramento) : base(int.MaxValue, schieramento)
        {
        }
        public override void Muovi(Cella nuovaPosizione)
        {
            int l = Math.Abs(nuovaPosizione.Lettera - Posizione.Lettera);
            int n = Math.Abs(nuovaPosizione.Numero - Posizione.Numero);
            if (l <= 1 && n <= 1 && n + l >= 1)
            {
                Posizione = nuovaPosizione;
            }
            else
                Errore();
        }

        public override string ShortName => "R";
    }
}
