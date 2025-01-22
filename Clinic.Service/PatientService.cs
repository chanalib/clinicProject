using Clinic.Core.Models;
using Clinic.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Service
{
    public class PatientService
    {
        private readonly IRepositoryManager _patientRepository;
        public PatientService(IRepositoryManager patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public IEnumerable<Patient> GetList()
        {
            return _patientRepository.patients.GetList();
        }

        public Patient GetById(int id)
        {
            return _patientRepository.patients.GetById(id);
        }
        public Patient Add(Patient user)
        {
            return _patientRepository.patients.Add(user);
            _patientRepository.Save();
        }
        public Patient Update(Patient patient)
        {
            return _patientRepository.patients.Update(patient);
            _patientRepository.Save();

        }

        public void Delete(int id)
        {
            _patientRepository.patients.Delete(id);
            _patientRepository.Save();

        }
    }
}
