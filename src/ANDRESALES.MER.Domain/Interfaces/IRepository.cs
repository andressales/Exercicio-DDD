using ANDRESALES.MER.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ANDRESALES.MER.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        // Leitura
        TEntity ObterPorId(Guid id);
        IEnumerable<TEntity> ObterTodos();
        IEnumerable<TEntity> ObterPaginado(int skip, int size);
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicado);

        // Escrita
        TEntity Adicionar(TEntity entity);
        TEntity Atualizar(TEntity entity);
        void Remover(Guid id);

        int SaveChanges();
    }
}
