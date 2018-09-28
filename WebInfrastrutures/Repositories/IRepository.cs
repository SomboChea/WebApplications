using System;
using System.Collections.Generic;
using System.Text;

namespace SE.WebInfrastrutures.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Func<T, bool> predicate);
        T GetById(int id);
        void Create(T enity);
        void Update(T enity);
        void Delete(T enity);
        int Count(Func<T, bool> predicate);

    }
}
