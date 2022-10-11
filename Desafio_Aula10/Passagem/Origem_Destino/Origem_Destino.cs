using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public class Origem_Destino
    {
        public static string Origem { get => "São Leopoldo"; }
        public string Destino { get; set; }

        public Origem_Destino(string destino)
        {
            Destino = destino;
        }
    }
}
