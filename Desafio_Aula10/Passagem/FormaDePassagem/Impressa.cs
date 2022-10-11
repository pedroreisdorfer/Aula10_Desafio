using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public class Impressa : FormaDePassagem
    {
        public override int Id_FormaDePassagem { get => 2; }

        public override string FormaPassagem { get => "Impressa"; }

        public Impressa()
        {

        }

        public override void ValidaFormaPassagem()
        {
            throw new NotImplementedException();
        }



        public override double CalcularValorPassagem(double valor) // pensar caso tiver seguro
        {
            Valor = valor;
            return Valor;

        }
    }
}
