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
        List<Doctor> GetList();

        Doctor? GetById(int id);

        Doctor Add(Doctor user);

        Doctor Update(Doctor user);

        void Delete(int id);
    }
}
