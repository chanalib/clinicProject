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
        IEnumerable<Patient> GetList();
        Patient GetById(int id);
        void AddValue(Patient patient);
        void Update(Patient patient);
        void Delete(Patient patient);
    }
}
