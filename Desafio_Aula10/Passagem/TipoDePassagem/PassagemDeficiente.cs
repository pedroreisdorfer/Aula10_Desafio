using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public class PassagemDeficiente : TiposPassageiro
    {
        public override int Id_TipoPassageiro { get => 4; }
        public override string TipoPassageiro { get => "Deficiente"; }

        public Seguro seguro;

        public PoltronasViewModel PoltronaSelecionada_;

        public override string ToString()
        {
            return $"Pagamento Valor - {this.ValorTotalCompra:C}";
        }

        public override void ValidaTipoPassageiro()
        {
            Console.WriteLine("Passagem para passageiro Deficiente");
        }

        public override double CalcularTotalPagamento(double valor, Seguro seguro, PoltronasViewModel poltronasView) // pensar caso tiver seguro
        {

            ValorTotalCompra = 0 + (valor * seguro.ValorSeguro);
            return ValorTotalCompra;

        }
    }
}
