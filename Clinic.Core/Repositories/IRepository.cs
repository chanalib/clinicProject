﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Data.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetList();

        T? GetById(int id);

        T Add(T entity);

        T Update(T entity);

        void Delete(int id);
    }
}
