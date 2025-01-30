using Clinic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Repositories
{
    public interface IDoctorRepository
    {
<<<<<<< HEAD
      // List<Doctor> getList();
=======
        List<Doctor> GetList();

        Doctor? GetById(int id);

        Doctor Add(Doctor user);

        Doctor Update(Doctor user);

        void Delete(int id);
>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
    }
}
