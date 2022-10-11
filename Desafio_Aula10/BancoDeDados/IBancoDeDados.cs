using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public interface IBancoDeDados
    {
        public void insert();

        public void delete();

        public void update();

        public void select();
    }
}
