using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public abstract class TiposPassageiro 
    {
        public abstract int Id_TipoPassageiro { get; }
        public abstract string TipoPassageiro { get; }
        public double ValorTotalCompra { get; set; }
        public EnumTipoPassageiro enumTipoPassageiro { get; set; }

        public abstract void ValidaTipoPassageiro(); 
        public abstract double CalcularTotalPagamento(double valor, Seguro seguro, PoltronasViewModel poltronasView);
    }
}
