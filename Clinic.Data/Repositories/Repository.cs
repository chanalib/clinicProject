<<<<<<< HEAD
﻿using Clinic.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
=======
﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
<<<<<<< HEAD
        private readonly DataContext context1;
        protected readonly DbSet<T> _dbSet;
        public Repository(DataContext context)
        {
            context1 = context;
=======
        private readonly DbSet<T> _dbSet;

        public Repository(DataContext context)
        {
>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
            _dbSet = context.Set<T>();
        }
        public T Add(T entity)
        {
            _dbSet.Add(entity);
            return entity;
        }
<<<<<<< HEAD
=======

>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }
<<<<<<< HEAD
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
=======

        public IEnumerable<T> GetList()
        {
            return _dbSet.ToList();
        }

        public T? GetById(int id)
        {
            return _dbSet.Find(id);
        }

>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
        public T Update(T entity)
        {
            _dbSet.Update(entity);
            return entity;
        }
<<<<<<< HEAD

    }
=======
    }

>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
}
