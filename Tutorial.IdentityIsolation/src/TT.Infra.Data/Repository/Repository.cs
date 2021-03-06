﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using TT.Domain.Interfaces;
using TT.Infra.Data.Context;

namespace TT.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected TutorialContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository(TutorialContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }
        
        public virtual TEntity Adicionar(TEntity obj)
        {
            var objreturn = DbSet.Add(obj);
            return objreturn;
        }

        public virtual TEntity ObterPorId(int id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> ObterTodos()
        {
            return DbSet.ToList();
        }

        public virtual TEntity Atualizar(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;

            return obj;
        }

        public virtual void Remover(int id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
