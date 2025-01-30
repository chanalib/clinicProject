using Clinic.Core.Models;
using Clinic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Data.Repositories
{ 
    public class RepositoryManager: IRepositoryManager
    {
        private readonly DataContext _context;
        public IRepository<Doctor> doctors { get; }
        public IRepository<Patient> patients { get; }
        public IRepository<Turn> turns { get; }
        public IDoctorRepository Doctor { get; }
        public IPatientRepository Patient { get; } 
        public ITurnRepository Turn { get; }
        public RepositoryManager(DataContext context,IRepository<Doctor>
            doctorRepository,IRepository<Patient> patientRepository,
            IRepository<Turn> turnRepository,
            IDoctorRepository doctor, IPatientRepository patient, ITurnRepository turn)
        {
            _context = context;
            doctors = doctorRepository;
            patients = patientRepository;
            turns = turnRepository;
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
