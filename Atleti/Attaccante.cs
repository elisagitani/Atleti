using System;
using System.Collections.Generic;
using System.Text;

namespace Atleti
{
    class Attaccante:Calciatore
    {
        public int NumeroGoal { get; set; }

        public static Ruolo ruolo = Ruolo.Attaccante;
        public Attaccante(string nome, string cognome, int eta, int numeroMaglia)
            : base(nome, cognome, eta, ruolo, numeroMaglia)
        {
            NumeroGoal = 0;
        }


       
        public override string StampaDati()
        {
            return $"{base.StampaDati()} \nNumero Goal eseguiti durante una partita: {NumeroGoal}";
        }

    
    }
}
