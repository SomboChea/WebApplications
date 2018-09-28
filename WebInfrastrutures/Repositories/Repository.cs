using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SE.WebInfrastrutures.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly SEDbContext _context;

        public Repository(SEDbContext context)
        {
            _context = context;
        }

        protected void Save() => _context.SaveChanges();

        public int Count(Func<T, bool> predicate) => _context.Set<T>().Where(predicate).Count();

        public void Create(T enity)
        {
            _context.Add(enity);
            Save();
        }   

        public void Delete(T enity)
        {
            _context.Remove(enity);
            Save();
        }

        public IEnumerable<T> Find(Func<T, bool> predicate) => _context.Set<T>().Where(predicate);

        public IEnumerable<T> GetAll() => _context.Set<T>();

        public T GetById(int id) => _context.Set<T>().Find(id);

        public void Update(T enity)
        {
            _context.Entry(enity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }
    }
}
