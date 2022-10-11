using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public class ServidorPassagem
    {
        public void Salvar(TiposPassageiro tiposPassageiro, Origem_Destino origem_Destino, FormaDePassagem formaDePassagem)
        {
            Console.WriteLine($"Servidor AAA - Salvando pagamento: R$ {tiposPassageiro.ValorTotalCompra.ToString("f2")} ");
            Console.WriteLine($"Passagem de forma: {formaDePassagem.FormaPassagem}"); // colocar aqui lógica da forma de passagem
            Console.WriteLine($"Passageiro tipo: {tiposPassageiro.TipoPassageiro}");
            Console.WriteLine($"Origem: {Origem_Destino.Origem}");
            Console.WriteLine($"Origem: {origem_Destino.Destino}");
        }
    }
}
