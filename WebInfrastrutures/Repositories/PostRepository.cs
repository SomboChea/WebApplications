using System;
using System.Collections.Generic;
using System.Text;

namespace SE.WebInfrastrutures.Repositories
{
    public class PostRepository<T> : IRepository<T> where T : class
    {
        public int Count(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Create(T enity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T enity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T enity)
        {
            throw new NotImplementedException();
        }
    }
}
