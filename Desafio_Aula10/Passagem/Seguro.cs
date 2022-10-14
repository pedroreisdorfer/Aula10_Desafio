using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public class Seguro
    {
        public int Id_Seguro { get; set; }

        public double ValorSeguro { get; set; }

        public Seguro(int tipo)
        {
            if (tipo == 1)
            {
                ValorSeguro = 0.03;
            }
            if (tipo == 2)
            {
                ValorSeguro = 0;
            }
        }

    }
}
