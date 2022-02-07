using Domain.Base;
using Domain.Interfaces;
using InfraData.DataContext;
using Microsoft.EntityFrameworkCore;

namespace InfraData.Base
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public void Add(T entity) => _context.Set<T>().Add(entity);

        public void Update(T entity) => _context.Set<T>().Update(entity);

        public void Delete(T entity) => _context.Set<T>().Remove(entity);

        public void SaveChanges() => _context.SaveChanges();

        public IQueryable<T> GetAll() => _context.Set<T>();

        public T Get(Guid id) => _context.Set<T>().Find(id);
    }
}
