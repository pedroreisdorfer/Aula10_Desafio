using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public class Origem_Destino
    {
        public string Origem { get; set; }
        public string Destino { get; set; }

        public Origem_Destino(string origem, string destino)
        {
            this.Origem = origem;
            this.Destino = destino;
        }
    }
}
