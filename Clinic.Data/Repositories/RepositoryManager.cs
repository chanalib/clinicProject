using Clinic.Core.Models;
using Clinic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Data.Repositories
<<<<<<< HEAD
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
=======
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
>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
            IRepository<Turn> turnRepository,
            IDoctorRepository doctor, IPatientRepository patient, ITurnRepository turn)
        {
            _context = context;
<<<<<<< HEAD
            doctors = doctorRepository;
            patients = patientRepository;
            turns = turnRepository;
            Doctor = doctor;
            Patient = patient;  
=======
            Doctors = doctorRepository;
            Patients = patientRepository;
            Turns = turnRepository;
            Doctor = doctor;
            Patient = patient;
>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
            Turn = turn;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
<<<<<<< HEAD
=======
}
>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
