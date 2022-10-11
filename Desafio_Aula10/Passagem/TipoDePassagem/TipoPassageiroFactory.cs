using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10
{
    public static class TipoPassageiroFactory
    {
        public static TiposPassageiro ValidadorTipoPassageiro(string id_TipoPassageiro)
        {
            bool converteuEmTipoPassageiro = Enum.TryParse(id_TipoPassageiro, out EnumTipoPassageiro tipoPassageiro);
            if (converteuEmTipoPassageiro)
            {
                switch (tipoPassageiro)
                {
                    case EnumTipoPassageiro.normal:
                        return new PassagemNormal();
                    case EnumTipoPassageiro.estudante:
                        return new PassagemEstudante();
                    case EnumTipoPassageiro.aposentado:
                        return new PassagemAposentado();
                    case EnumTipoPassageiro.deficiente:
                        return new PassagemDeficiente();
                    default:
                        throw new Exception("Tipo de passageiro não identificado");
                }
            }
            else
            {
                throw new Exception("ID inválido, Tipo de passageiro não identificado!");
            }
        }
    }
}
