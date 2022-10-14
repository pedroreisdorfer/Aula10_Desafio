using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public class PassagemEstudante : TiposPassageiro
    {
        public override int Id_TipoPassageiro { get => 2; }
        public override string TipoPassageiro { get => "Estudante"; }
        public Seguro seguro { get; set; }
        public PoltronasViewModel PoltronaSelecionada_ { get; set; } 

        public override string ToString()
        {
            return $"Pagamento Valor - {this.ValorTotalCompra:C}";
        }

        public override void ValidaTipoPassageiro()
        {
            Console.WriteLine("Passagem para passageiro estudante");
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
            else
            {

                ValorTotalCompra = (valor - (valor * 0.05)) + (valor * seguro.ValorSeguro);
                return ValorTotalCompra;
            }
        }
    }
}
