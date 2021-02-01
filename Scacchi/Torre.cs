using System;
using System.Collections.Generic;
using System.Text;

namespace Scacchi
{
    public class Torre : Pezzo
    {
        public Torre(Colore schieramento) : base(5, schieramento) { }
        public override void Muovi(Cella nuovaPosizione)
        {
            if (nuovaPosizione.Lettera == Posizione.Lettera ||
                nuovaPosizione.Numero == Posizione.Numero)
            {

                Posizione = nuovaPosizione;
            }
            else
                Errore();
        }
    }
}
