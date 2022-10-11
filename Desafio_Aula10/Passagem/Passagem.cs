using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public class Passagem
        // ver se vou usar essa classe
    {
        //public string Origem { get; set; }
        //public string Destino { get; set; }

        public Origem_Destino Origem_Destino;

        public PoltronasViewModel poltronasViewModel;

        //public DB_ContextPoltronas DB_ContextPoltronas_;

        //private readonly DB_ContextPoltronas DB_ContextPoltronas_;

        // acesso a poltrona que foi digita no Console, buscando no banco de dados

        public TiposPassageiro tiposPassageiro;

        public void ImpressaoPassagem()
        {
            Console.WriteLine($"Origem: {Origem_Destino.Origem}");
            Console.WriteLine($"Destino: {Origem_Destino.Destino}");
            Console.WriteLine($"Tipo de Passagem: {tiposPassageiro.TipoPassageiro}");
            Console.WriteLine($"Poltrona Selecionada: {poltronasViewModel.Poltrona}");
            Console.WriteLine($"Valor total: {tiposPassageiro.ValorTotalCompra}");
        }
    }
}
