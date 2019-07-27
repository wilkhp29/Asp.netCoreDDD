using Config;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrogStoreInfra.Repositories
{
    public class Generic<T> : IGeneric<T>,IDisposable where T : class
    {
        private DbContextOptionsBuilder<ContextBase> _OptionsBuilder;

        public Generic()
        {
            _OptionsBuilder = new DbContextOptionsBuilder<ContextBase>();
        }

        ~Generic()
        {
            Dispose(false);
        }

        public void Delete(int id)
        {
            using (var banco = new ContextBase(_OptionsBuilder.Options))
            {
                var Objeto = banco.Set<T>().Find(id);
                banco.Remove(Objeto);
                banco.SaveChanges();
            };

        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool Status)
        {
            if (!Status) return;
        }

        public IEnumerable<T> GetAll()
        {
            using (var banco = new ContextBase(_OptionsBuilder.Options))
            {
                return banco.Set<T>().ToList();
            };
        }

        public T GetById(int id)
        {
            using (var banco = new ContextBase(_OptionsBuilder.Options))
            {
                return banco.Set<T>().Find(id);
            };
        }

        public void Save(T entity)
        {
            using (var banco = new ContextBase(_OptionsBuilder.Options))
            {
                banco.Add(entity);
                banco.SaveChanges();
            };
        }

        public T Update(T entity)
        {
            using (var banco = new ContextBase(_OptionsBuilder.Options))
            {
                banco.Update(entity);
                banco.SaveChanges();
            };
            return entity;
        }
    }
}
