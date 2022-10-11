using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public static class FornaDePassagemFactory 
    {
        public static FormaDePassagem ValidaFormaPassagem(string id_FormaPassagem)
        {
            bool converteuEmFormaDePassagem = Enum.TryParse(id_FormaPassagem, out EnumFormaDePassagem formaDePassagem);
            if (converteuEmFormaDePassagem)
            {
                switch (formaDePassagem)
                {
                    case EnumFormaDePassagem.Digital:
                        return new Digital();
                    case EnumFormaDePassagem.Imprssa:
                        return new Impressa();
                    default:
                        throw new Exception("Forma de Passagem não identificada");
                }
            }
            else
            {
                throw new Exception("ID inválido, Forma de Passagem não identificada!");
            }
        }
    }
}
