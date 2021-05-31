using System;

namespace Atleti
{
    class Program
    {
        //Gli atleti hanno nome, cognome, età
        //Calciatori hanno ruolo e numero maglia (ruoli=centrocampista, difensore, portiere e attaccante)
        //Portieri hanno di default il numero maglia=1
        //Gli attaccanti hanno numero gol fatti durante la partita 


        //Una squadra di calcio è formata da 11 calciatori di cui
        //-1 portiere
        //-4 difensori
        //-3 centrocampisti
        //-3 attaccanti

        //Per svolgere una partita serve anche un arbitro (l'arbitro è un atleta)
        static void Main(string[] args)
        {
            Squadra squadra1 = new Squadra("Milan");
            


            var listaCalciatori = GestioneSquadra.CaricaCalciatori();
            
            int scelta;
            do
            {

                Console.WriteLine("\n1-Inserisci calciatore");
                Console.WriteLine("2-Visualizza formazione");
                Console.WriteLine("0-Esci");

                do
                {

                } while (!int.TryParse(Console.ReadLine(), out scelta) && scelta >= 0 && scelta <= 2);

                switch (scelta)
                {
                    case 1:
                        int risposta;
                        Console.WriteLine("Ecco la lista dei possibili calciatori: ");
                        Console.WriteLine("----------------------------------------------------------------------");
                        foreach (var item in listaCalciatori)
                        {
                            Console.WriteLine(item.StampaDati());
                            Console.WriteLine("----------------------------------------------------------------------");
                        }
                        do
                        {
                            Console.WriteLine("Quale calciatore vuoi inserire nella tua squadra? \nInserisci un numero da 0 a 11");

                        } while (!int.TryParse(Console.ReadLine(), out risposta) && risposta >= 0 && risposta <= 11);


                        bool possoInserirlo = GestioneSquadra.GestioneNumero(squadra1, listaCalciatori[risposta]);

                        if (possoInserirlo == true)
                            squadra1.ListaCalciatori.Add(listaCalciatori[risposta]);
                        else
                        {
                            Console.WriteLine($"Hai superato il numero massimo di giocatori nel ruolo di {listaCalciatori[risposta].Ruolo}");
                        }
                     
                        break;

                    case 2:
                        Console.WriteLine("Ecco la tua formazione");

                        foreach(var item in squadra1.ListaCalciatori)
                        {
                            Console.WriteLine("----------------------------------------------------------------------");
                            Console.WriteLine(item.StampaDati());
                        }
                        break;
                    case 0:
                        return;
                }





            } while (true);
        
        }
    }
}
