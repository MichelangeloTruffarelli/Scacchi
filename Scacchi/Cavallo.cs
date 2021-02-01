using System;
using System.Collections.Generic;
using System.Text;

namespace Scacchi
{
    public class Cavallo : Pezzo
    {
        public Cavallo(Colore schieramento) : base(3, schieramento) { }
        public override void Muovi(Cella nuovaPosizione)
        {
            int h = Math.Abs(nuovaPosizione.Numero - Posizione.Numero);
            int v = Math.Abs(nuovaPosizione.Lettera - Posizione.Lettera);
            if ((h == 3 && v == 1) || (h == 1 && v == 3))
            {
                Posizione = nuovaPosizione;
            }
            else
                Errore();
        }
    }
}
