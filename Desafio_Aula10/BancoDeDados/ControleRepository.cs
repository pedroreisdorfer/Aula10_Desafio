using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aula10.BancoDeDados
{
    public class ControleRepository : IBancoDeDados
    {
        

        private IBancoDeDados bancoDados_;
        public ControleRepository(IBancoDeDados bancoDados_)
        {
            this.bancoDados_ = bancoDados_;
        }

        public void delete()
        {
            bancoDados_.delete();
        }

        public void Excluir(PoltronasViewModel poltronaViewModel)
        {
            DB_ContextPoltronas.InicializaDB();
            DB_ContextPoltronas.ListaPoltronas.Remove(poltronaViewModel);
        }

        public void insert()
        {
            throw new NotImplementedException();
        }

        public void select()
        {
            throw new NotImplementedException();
        }

        public void update()
        {
            throw new NotImplementedException();
        }
    }
}
