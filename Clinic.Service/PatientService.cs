using Clinic.Core.Models;
<<<<<<< HEAD
using Clinic.Core.Repositories;
using Clinic.Core.Servicies;
=======
>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
using Clinic.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Service
{
<<<<<<< HEAD

    public class PatientService : IPatientService
=======
    public class PatientService
>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
    {
        private readonly IRepositoryManager _patientRepository;
        public PatientService(IRepositoryManager patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public IEnumerable<Patient> GetList()
        {
<<<<<<< HEAD
            return _patientRepository.patients.GetAll();
        }
=======
            return _patientRepository.patients.GetList();
        }

>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
        public Patient GetById(int id)
        {
            return _patientRepository.patients.GetById(id);
        }
<<<<<<< HEAD
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

=======
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
>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
    }

}
