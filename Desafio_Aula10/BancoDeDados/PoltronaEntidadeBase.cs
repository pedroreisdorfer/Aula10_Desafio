using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public abstract class PoltronaEntidadeBase
    {
        public string Id { get; set; }

        public PoltronaEntidadeBase()
        {
            Id = Guid.NewGuid().ToString();   
        }
    }
}
