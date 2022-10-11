using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public class ServidorPassagem
    {
        public void Salvar(TiposPassageiro tiposPassageiro, Origem_Destino origem_Destino, FormaDePassagem formaDePassagem)
        {
            Console.WriteLine();
            Console.WriteLine($"Salvando passagem --------------");
            Console.WriteLine($"Valor total: R$ {tiposPassageiro.ValorTotalCompra.ToString("f2")}");
            Console.WriteLine($"Passagem de forma: {formaDePassagem.FormaPassagem}"); 
            Console.WriteLine($"Passageiro tipo: {tiposPassageiro.TipoPassageiro}");
            Console.WriteLine($"Origem: {Origem_Destino.Origem}");
            Console.WriteLine($"Origem: {origem_Destino.Destino}");
        }
    }
}
