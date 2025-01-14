using Clinic.Core.Models;
using Clinic.Core.Repositories;
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
        //public List<Doctor> getAll()
        //{
        //    return _doctorRepository.getList();
        //}

        IEnumerable<Doctor> IDoctorService.getAll()
        {
            return _doctorRepository.getList();
        }
    }

    public interface IDoctorService
    {
        IEnumerable<Doctor> getAll();
    }
}
