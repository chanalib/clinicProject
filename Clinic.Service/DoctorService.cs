using Clinic.Core.Models;
using Clinic.Core.Repositories;
using Clinic.Core.Servicies;
using Clinic.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Service
{
    public class DoctorService: IDoctorService
    {
        private readonly IRepositoryManager _doctorRepository;
        public DoctorService(IRepositoryManager doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }
        public IEnumerable<Doctor> GetList()
        {
<<<<<<< HEAD
            return _doctorRepository.doctors.GetAll();
        }
        public Doctor GetById(int id)
        {
            return _doctorRepository.doctors.GetById(id);
        }
        public void Add(Doctor doctor)
        {
            _doctorRepository.doctors.Add(doctor);
            _doctorRepository.Save();
        }
        public void Update(Doctor doctor)
        {
            _doctorRepository.doctors.Update(doctor);
            _doctorRepository.Save();
        }
        public void Delete(Doctor doctor)
        {
            _doctorRepository.doctors.Delete(doctor);
            _doctorRepository.Save();
        }
        
    }
=======
            return _doctorRepository.doctors.GetList();
        }

        public Doctor GetById(int id)
        {
            return _doctorRepository.doctors.GetById(id);
        }
        public Doctor Add(Doctor user)
        {
            return _doctorRepository.doctors.Add(user);
            _doctorRepository.Save();
        }
        public Doctor Update(Doctor doctor)
        {
            return _doctorRepository.doctors.Update(doctor);
            _doctorRepository.Save();

        }

        public void Delete(int id)
        {
            _doctorRepository.doctors.Delete(id);
            _doctorRepository.Save();

        }
    }

>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
}

 
