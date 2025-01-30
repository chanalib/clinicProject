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

    public class PatientService : IPatientService
    {
        private readonly IRepositoryManager _patientRepository;
        public PatientService(IRepositoryManager patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public IEnumerable<Patient> GetList()
        {
            return _patientRepository.patients.GetAll();
        }
        public Patient GetById(int id)
        {
            return _patientRepository.patients.GetById(id);
        }
        public void AddValue(Patient patient)
        {
            _patientRepository.patients.Add(patient);
            _patientRepository.Save();
        }
        public void Update(Patient patient)
        {
            _patientRepository.patients.Update(patient);
            _patientRepository.Save();
        }
        public void Delete(Patient doctor)
        {
            _patientRepository.patients.Delete(doctor);
            _patientRepository.Save();
        }

    }

}
