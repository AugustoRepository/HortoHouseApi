using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HortoHouse.Repository.Contracts
{
    public interface IBaseRepository<T> where T : class
    {
        void Inserir(T entity);
        void Alterar(T entity);
        void Excluir(T entity);

        List<T> ObterTodos();

        T ObterPorId(Guid id);
    }
}
