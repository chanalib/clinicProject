using Clinic.Core.Models;
using Clinic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Data.Repositories
{
<<<<<<< HEAD
    public class PatientRepository: Repository<Patient> ,IPatientRepository
    {
        public PatientRepository(DataContext context) : base(context)
        {
=======
    public class PatientRepository : Repository<Patient>, IPatientRepository
    {
        private readonly DataContext _context;
        public PatientRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public List<Patient> GetList()
        {
            return _context.Patients.ToList();
        }

        public Patient? GetById(int id)
        {
            return _context.Patients.FirstOrDefault(x => x.Id == id);
        }

        public Patient Add(Patient user)
        {
            _context.Patients.Add(user);
            return user;
        }

        public Patient Update(Patient patient)
        {
            var existingPatient = GetById(patient.Id);
            if (existingPatient is null)
            {
                throw new Exception("Patient not found");
            }
            existingPatient.Name = patient.Name;
            existingPatient.Email = patient.Email;
            existingPatient.Adress = patient.Adress;
            existingPatient.Age = patient.Age;

            return existingPatient;
        }

        public void Delete(int id)
        {
            var existingPatient = GetById(id);
            if (existingPatient is not null)
            {
                _context.Patients.Remove(existingPatient);
            }
>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
        }
    }
}
