using Clinic.Core.Models;
using Clinic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Data.Repositories
{
    public class RepositoryManager
    {
        private readonly DataContext _context;
        public IRepository<Doctor> Doctors { get; }
        public IRepository<Patient> Patients { get; }
        public IRepository<Turn> Turns { get; }
        public IDoctorRepository Doctor { get; }
        public IPatientRepository Patient { get; }
        public ITurnRepository Turn { get; }
        public RepositoryManager(DataContext context, IRepository<Doctor>
            doctorRepository, IRepository<Patient> patientRepository,
            IRepository<Turn> turnRepository,
            IDoctorRepository doctor, IPatientRepository patient, ITurnRepository turn)
        {
            _context = context;
            Doctors = doctorRepository;
            Patients = patientRepository;
            Turns = turnRepository;
            Doctor = doctor;
            Patient = patient;
            Turn = turn;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
}
