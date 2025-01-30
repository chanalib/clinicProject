using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Repositories
{
    public interface IRepository<T> where T : class
    {
<<<<<<< HEAD
        IEnumerable<T> GetAll();
=======
        IEnumerable<T> GetList();

>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
        T? GetById(int id);
        T Add(T entity);
        T Update(T entity);
<<<<<<< HEAD
        void Delete(T entity);

=======

        void Delete(int id);
>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
    }
}
