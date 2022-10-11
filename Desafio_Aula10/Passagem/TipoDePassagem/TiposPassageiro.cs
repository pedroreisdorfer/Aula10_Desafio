using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public abstract class TiposPassageiro // ajustar
    {
        public abstract int Id_TipoPassageiro { get; }
        public abstract string TipoPassageiro { get; }
        public double ValorTotalCompra { get; set; }
        public EnumTipoPassageiro enumTipoPassageiro { get; set; }

        //public bool ValidaValorPagamento(string ValorPagamento) // ver se vou usar
        //{
        //    bool valorValido = double.TryParse(ValorPagamento, out double valorConvertido) && valorConvertido >= 0;
        //    if (valorValido)
        //    {
        //        this.ValorTotalCompra = valorConvertido;
        //        return valorValido;
        //    }
        //    else
        //    {
        //        throw new Exception("Valor inválido, verifique!");
        //    }
        //}
        public abstract void ValidaTipoPassageiro(); ///

        public abstract double CalcularTotalPagamento(double valor, Seguro seguro, PoltronasViewModel poltronasView);
    }
}
