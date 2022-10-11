using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public class PassagemNormal : TiposPassageiro
    {
        public override int Id_TipoPassageiro { get => 1; }
        public override string TipoPassageiro { get => "Normal"; }

        public Seguro seguro;

        public override void ValidaTipoPassageiro()
        {
            Console.WriteLine("Passagem para passageiro normal");
        }

        public override double CalcularTotalPagamento(double valor, Seguro seguro, PoltronasViewModel poltronasView) // pensar caso tiver seguro
        {
            ValorTotalCompra = valor + (valor * seguro.ValorSeguro);
            return ValorTotalCompra;

        }
    }
}
