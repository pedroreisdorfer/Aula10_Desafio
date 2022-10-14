using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public class Digital : FormaDePassagem
    {

        public override int Id_FormaDePassagem { get => 1; }

        public override string FormaPassagem { get => "Digital (desconto de 5%)"; }

        public Digital()
        {
        }

        public override void ValidaFormaPassagem()
        {
            throw new NotImplementedException();
        }

        public override double CalcularValorPassagem(double valor) 
        {
            Valor = valor - (valor * 0.05);
            return Valor;

        }

    }
}
