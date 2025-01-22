using Clinic.Core.Models;
using Clinic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Data.Repositories
{
    public interface IRepositoryManager
    {
        public IRepository<Doctor> doctors { get; }
        public IRepository<Patient> patients { get; }
        public IRepository<Turn> turns { get; }
        public IDoctorRepository Doctor { get; }
        public IPatientRepository Patient { get; }
        public ITurnRepository Turn { get; }
        void Save();
    }
}
