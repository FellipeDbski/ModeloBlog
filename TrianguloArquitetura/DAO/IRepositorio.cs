using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloArquitetura.DAO
{
    interface IRepositorio<T> where T : class
    {
        //Implementação do Padrão Repository.
        //http://martinfowler.com/eaaCatalog/repository.html
        //

        void Adiciona(T entity);
        void Remove(T entity);
        T BuscarPorID(int id);
        T[] BuscaTodos();
        IQueryable<T> Query(Expression<Func<T, bool>> filter);
    }
}
