using Clinic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Servicies
{
    public interface IPatientService
    {
<<<<<<< HEAD
        IEnumerable<Patient> GetList();
        Patient GetById(int id);
        void AddValue(Patient patient);
        void Update(Patient patient);
        void Delete(Patient patient);
=======
        List<Patient> GetList();

        Patient? GetById(int id);

        Patient Add(Patient user);

        Patient Update(Patient user);

        void Delete(int id);
>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
    }
}
