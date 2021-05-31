using System;
using System.Collections.Generic;
using System.Text;

namespace Atleti
{
    enum Ruolo
    {
        Portiere=1,
        Centrocampista=2,
        Difensore=3,
        Attaccante=4
    }
    class Calciatore: Atleta
    {
        public Ruolo Ruolo { get; set; }
        public int NumeroMaglia { get; set; }
        public Calciatore(string nome, string cognome,int eta, Ruolo ruolo, int numeroMaglia)
            :base(nome,cognome,eta)
        {
            Ruolo = ruolo;
            NumeroMaglia = numeroMaglia;
        }

        public override string StampaDati()
        {
            return $"{base.StampaDati()} \nRuolo: {Ruolo} \nNumero Maglia: {NumeroMaglia}";
        }



    }
}
