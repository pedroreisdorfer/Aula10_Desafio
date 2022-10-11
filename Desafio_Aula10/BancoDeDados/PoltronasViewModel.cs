using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public class PoltronasViewModel : PoltronaEntidadeBase
    {
        public string Poltrona { get; set; }

        public PoltronasViewModel(string poltrona)
        {
            Poltrona = poltrona;
        }
    }
}
