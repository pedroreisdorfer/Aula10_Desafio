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

        public PoltronasViewModel PoltronaSelecionada_ { get; set; } // ser se é preciso

        public override string ToString()
        {
            return $"Pagamento Valor - {this.ValorTotalCompra:C}";
        }

        public override void ValidaTipoPassageiro()
        {
            Console.WriteLine("Passagem para passageiro estudante");
        }

        public override double CalcularTotalPagamento(double valor, Seguro seguro, PoltronasViewModel poltronasView) // pensar caso tiver seguro
        {
            if (poltronasView.Poltrona == "P1" ||
                poltronasView.Poltrona == "P2" ||
                poltronasView.Poltrona == "P3" ||
                poltronasView.Poltrona == "P4" ||
                poltronasView.Poltrona == "P5")
            {
                ValorTotalCompra = valor - (valor * 0.15) + (valor * seguro.ValorSeguro);
                return ValorTotalCompra;
            }
            else
            {
                ValorTotalCompra = valor + (valor * seguro.ValorSeguro);
                return ValorTotalCompra;
            }
        }
    }
}
