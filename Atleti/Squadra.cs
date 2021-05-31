using System;
using System.Collections.Generic;
using System.Text;

namespace Atleti
{
    class Squadra
    {
        public string NomeSquadra { get; set; }
        public List<Calciatore> ListaCalciatori { get; set; } = new List<Calciatore>();

        public Squadra(string nome)
        {
            NomeSquadra = nome;
        }
    }
}
