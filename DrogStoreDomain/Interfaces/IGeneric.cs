using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IGeneric<T> where T : class
    {
        void Save(T entity);
        T Update(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Delete(int id);
    }
}
