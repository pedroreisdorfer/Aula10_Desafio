using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public class Origem_Destino
    {
        public static string Origem { get => "São Leopoldo"; }
        public string Destino { get; set; }
        public double ValorViagem { get; set; }

        public Origem_Destino(string destino)
        {
            Destino = destino;
        }

        public void CalculoValorPassagem(string destino)
        {
            if (destino == "Porto Alegre")
            {
                ValorViagem = 50.00;
            }

            if (destino == "Florianópolis")
            {
                ValorViagem = 200.00;
            }

            if (destino == "Curitiba")
            {
                ValorViagem = 300.00;
            }

            if (destino == "São Paulo")
            {
                ValorViagem = 400.00;
            }
        }
    }
}
