using System;
using System.Collections.Generic;
using System.Text;

namespace Atleti
{
    public class Atleta
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }

        public Atleta(string nome, string cognome, int eta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }

        public virtual string StampaDati()
        {
            return $"Nome: {Nome} \tCognome: {Cognome} \tEtà: {Eta}";
        }
    }
}
