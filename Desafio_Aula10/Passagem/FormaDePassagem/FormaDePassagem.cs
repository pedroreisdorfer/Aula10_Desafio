using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public abstract class FormaDePassagem
    {
        public abstract int Id_FormaDePassagem { get; }
        public abstract string FormaPassagem { get; }
        public double Valor { get; set; }
        public EnumFormaDePassagem enumFormaDePassagem { get; set; }

        //public abstract double CalcularTotalPagamento(double valor, Seguro seguro, PoltronasViewModel poltronasView);

        public abstract void ValidaFormaPassagem(); ///

        public abstract double CalcularValorPassagem(double valor);
    }
}
