using System;
using System.Collections.Generic;
using System.Text;

namespace Atleti
{
    class Portiere: Calciatore
    {
        public static int numeroMaglia=1;
        public static Ruolo ruolo = Ruolo.Portiere;
        public int NumeroGoalSubiti { get; set; }
        public Portiere(string nome,string cognome,int eta)
            :base(nome,cognome,eta,ruolo,numeroMaglia)
        {
            Ruolo = ruolo;
            NumeroMaglia = numeroMaglia;
            NumeroGoalSubiti = 0;
        }

        public override string StampaDati()
        {
           
            return $"{base.StampaDati()} \nNumero Goal subiti:{NumeroGoalSubiti}";
        }

    }
}

