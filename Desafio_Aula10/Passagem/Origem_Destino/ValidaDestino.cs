using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public abstract class ValidacaoDestino
    {
        public static Origem_Destino ValidadarDestinoExistente(string destinoSelecionado)
        {
            Origem_Destino destino = new Origem_Destino(destinoSelecionado);
            if (Origem_DestinoDB.ListaDestinos.Contains(destinoSelecionado))
            {
                return destino;
            }
            else
            {
                throw new Exception("Destino Inexistente!");
            }
        }
    }
}
