using ANDRESALES.MER.Domain.Interfaces;
using ANDRESALES.MER.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using ANDRESALES.MER.Infra.Data.Context;
using System.Data.Entity;

namespace ANDRESALES.MER.Infra.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly MERContext _db;
        protected readonly DbSet<TEntity> _dbSet;

        public Repository(MERContext context)
        {
            _db = context;
            _dbSet = _db.Set<TEntity>();
        }

        public virtual TEntity ObterPorId(Guid id)
        {
            return _dbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> ObterTodos()
        {
            return _dbSet.ToList();
        }

        public virtual IEnumerable<TEntity> ObterPaginado(int skip, int size)
        {
            return _dbSet.Skip(skip).Take(size).ToList();
        }

        public virtual IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicado)
        {
            return _dbSet.Where(predicado);
        }

        public virtual TEntity Adicionar(TEntity entity)
        {
            return _dbSet.Add(entity);
        }

        public TEntity Atualizar(TEntity entity)
        {
            var entry = _db.Entry(entity);
            _dbSet.Attach(entity);
            entry.State = EntityState.Modified;

            return entity;
        }

        public void Remover(Guid id)
        {
            var entity = new TEntity{ Id = id };
            _dbSet.Remove(entity);
        }

        public int SaveChanges()
        {
            return _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
