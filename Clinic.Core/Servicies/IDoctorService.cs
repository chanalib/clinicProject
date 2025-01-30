using Clinic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Servicies
{
    public interface IDoctorService
    {
        IEnumerable<Doctor> GetList();

        Doctor GetById(int id);

        void Add(Doctor user);

        void Update(Doctor user);

        void Delete(Doctor user);
    }
}
 