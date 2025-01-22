using Clinic.Core.Models;
using Clinic.Core.Repositories;
using Clinic.Core.Servicies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Service
{
    public class DoctorService: IDoctorService
    {
        private readonly IDoctorRepository _doctorRepository;
        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }
        public List<Doctor> GetList()
        {
            return _doctorRepository.GetAll();
        }

        public Doctor? GetById(int id)
        {
            return _doctorRepository.GetById(id);
        }
        public Doctor Add(Doctor user)
        {
            return _doctorRepository.Add(user);
        }
        public Doctor Update(Doctor doctor)
        {
            return _doctorRepository.Update(doctor);
        }

        public void Delete(int id)
        {
            _doctorRepository.Delete(id);
        }
    }

}
