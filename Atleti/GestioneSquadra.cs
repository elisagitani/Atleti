using System;
using System.Collections.Generic;
using System.Text;

namespace Atleti
{
    static class GestioneSquadra
    {
        public static List<Calciatore> listaCalciatori = new List<Calciatore>();
        public static int countPortieri = 0;
        public static int countDifensori = 0;
        public static int countCentrocampisti = 0;
        public static int countAttaccanti = 0;

        public static List<Calciatore> CaricaCalciatori()
        {

            Portiere p = new Portiere("Gigi", "Buffon", 43);
            Portiere p2 = new Portiere("Gianluigi", "Donnarumma", 25);
            listaCalciatori.Add((Calciatore)p);
            listaCalciatori.Add((Calciatore)p2);
            Attaccante a1 = new Attaccante("Cristiano", "Ronaldo", 36, 7);
            listaCalciatori.Add((Calciatore)a1);
            Attaccante a2 = new Attaccante("Ciro", "Immobile", 30, 10);
            listaCalciatori.Add((Calciatore)a2);
            Attaccante a3 = new Attaccante("Mauro", "Icardi", 32, 14);
            listaCalciatori.Add((Calciatore)a3);
            Calciatore c1 = new Calciatore("Giorgio", "Chiellini", 38, Ruolo.Difensore, 11);
            listaCalciatori.Add(c1);
            Calciatore c2 = new Calciatore("Leonardo", "Bonucci", 34, Ruolo.Difensore, 15);
            listaCalciatori.Add(c2);
            Calciatore c3 = new Calciatore("Gian Marco", "Ferrari", 38, Ruolo.Difensore, 22);
            listaCalciatori.Add(c3);
            Calciatore c4 = new Calciatore("Mattia", "Desciglio", 38, Ruolo.Difensore, 23);
            listaCalciatori.Add(c4);
            Calciatore c5 = new Calciatore("Claudio", "Marchisio", 35, Ruolo.Centrocampista, 8);
            listaCalciatori.Add(c5);
            Calciatore c6 = new Calciatore("Bruno", "Fernandez", 30, Ruolo.Centrocampista, 24);
            listaCalciatori.Add(c6);
            Calciatore c7 = new Calciatore("Mattia", "Desciglio", 38, Ruolo.Centrocampista, 23);
            listaCalciatori.Add(c7);

            return listaCalciatori;
        }

        public static bool GestioneNumero(Squadra squadra, Calciatore calciatore)
        {

            Dictionary<Ruolo, int> numeroMassimoCalciatori = new Dictionary<Ruolo, int>();
            numeroMassimoCalciatori.Add(Ruolo.Portiere, 1);
            numeroMassimoCalciatori.Add(Ruolo.Attaccante, 3);
            numeroMassimoCalciatori.Add(Ruolo.Difensore, 4);
            numeroMassimoCalciatori.Add(Ruolo.Centrocampista, 3);

            int count = 0;

            foreach (var item in squadra.ListaCalciatori)
            {
                if (calciatore.Ruolo == item.Ruolo)
                {
                    count++;
                }
            }

            if (count < numeroMassimoCalciatori[calciatore.Ruolo])
                return true;
            else
                return false;

        }
    }
}