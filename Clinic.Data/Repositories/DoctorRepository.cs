using Clinic.Core.Models;
using Clinic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Data.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly DataContext _context;
        public DoctorRepository(DataContext context)
        {
            _context = context;
        }

        public List<Doctor> GetAll()
        {
            return _context.Doctors;
        }

        public Doctor? GetById(int id)
        {
            return _context.Doctors.FirstOrDefault(x => x.Id == id);
        }

        public Doctor Add(Doctor user)
        {
            _context.Doctors.Add(user);
            return user;
        }

        public Doctor Update(Doctor doctor)
        {
            var existingDoctor = GetById(doctor.Id);
            if (existingDoctor is null)
            {
                throw new Exception("Doctor not found");
            }
            existingDoctor.Name = doctor.Name;
            existingDoctor.Email = doctor.Email;
            existingDoctor.Password = doctor.Password;

            return existingDoctor;
        }

        public void Delete(int id)
        {
            var existingDoctor = GetById(id);
            if (existingDoctor is not null)
            {
                _context.Doctors.Remove(existingDoctor);
            }
        }
    }
}
