using Clinic.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DataContext context1;
        protected readonly DbSet<T> _dbSet;
        public Repository(DataContext context)
        {
            context1 = context;
            _dbSet = context.Set<T>();
        }
        public T Add(T entity)
        {
            _dbSet.Add(entity);
            return entity;
        }
        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }
        public IEnumerable<T> GetAll()
        {
           context1.turns.Include(a => a.patient).ToList();
           context1.turns.Include(a => a.doctor).ToList();

            return _dbSet.ToList();
        }
        public T? GetById(int id) 
        {
            context1.turns.Include(a => a.patient).FirstOrDefault(p=>p.Id==id);
            context1.turns.Include(a => a.doctor).FirstOrDefault(p => p.Id == id);
            return _dbSet.FirstOrDefault(p => EF.Property<int>(p, "Id") == id);
        }
        public T Update(T entity)
        {
            _dbSet.Update(entity);
            return entity;
        }

    }
}
