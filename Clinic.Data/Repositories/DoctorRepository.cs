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
    public class DoctorRepository : Repository<Doctor>, IDoctorRepository
=======
    public class DoctorRepository : IDoctorRepository
>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
    {
        public DoctorRepository(DataContext context) : base(context)
        {
<<<<<<< HEAD

=======
            _context = context;
        }

        public List<Doctor> GetAll()
        {
            return _context.Doctors;
>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
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
