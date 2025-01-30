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
}

 
