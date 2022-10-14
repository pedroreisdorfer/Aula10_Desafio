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

        public override double CalcularTotalPagamento(double valor, Seguro seguro, PoltronasViewModel poltronasView) 
        {
            string polstronaSelect = poltronasView.Poltrona;
            if (polstronaSelect == ("P1") ||
                polstronaSelect == "P2" ||
                polstronaSelect == "P3" ||
                polstronaSelect == "P4" ||
                polstronaSelect == "P5")
            {
                ValorTotalCompra = valor - (valor * 0.15) + (valor * seguro.ValorSeguro);
                return ValorTotalCompra;
            }

            ValorTotalCompra = valor + (valor * seguro.ValorSeguro);
            return ValorTotalCompra;

        }
    }
}
