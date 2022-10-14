using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public abstract class ValidacaoPoltrona
    {
        public static PoltronasViewModel ValidadarPoltronaExistente(string poltronaSelecionada)
        {
            PoltronasViewModel poltrona = new PoltronasViewModel(poltronaSelecionada);
            if (DB_ContextPoltronas.ListaPoltronas.Contains(poltronaSelecionada))
            {            
                return poltrona;
            }
            else
            {
                throw new Exception("Poltrona Inexistente!");
            }
        }
    }
}
