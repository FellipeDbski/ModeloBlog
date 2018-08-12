using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using TrianguloArquitetura.Models;

namespace TrianguloArquitetura.DAO
{
    public class PublicacaoRepositorio : IRepositorio<Publicacao>, IDisposable
    {

        private TrianguloContext _Contexto;

        public PublicacaoRepositorio()
        {
            _Contexto = new TrianguloContext();
        }

        public void Adiciona(Publicacao entity)
        {
            _Contexto.Publicacao.Add(entity);
            _Contexto.SaveChanges();
        }

        public void Remove(Publicacao entity)
        {
            _Contexto.Publicacao.Remove(entity);
            _Contexto.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Publicacao[] BuscaTodos()
        {
            throw new NotImplementedException();
        }

        public Publicacao BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Publicacao> Query(Expression<Func<Publicacao, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}