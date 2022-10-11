using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public abstract class Origem_DestinoDB
    {
       
        public static List<string> ListaDestinos;

        static Origem_DestinoDB()
        {
            ListaDestinos = new List<string>();

            InicializaDBDestino();

        }

        public static void InicializaDBDestino()
        {
            string destino = "Porto Alegre";
            ListaDestinos.Add(destino);

            destino = "Florianópolis";
            ListaDestinos.Add(destino);

            destino = "Curitiba";
            ListaDestinos.Add(destino);
        }

    }
}
