using Clinic.Core.Models;
using Clinic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Data.Repositories
{
    public class DoctorRepository:IDoctorRepository 
    {
        private readonly DataContext _context;
        public DoctorRepository(DataContext context)
        {
            _context = context;
        }
     
        public List<Doctor> getList()
        {
            return _context.Doctors;
        }
    }
}
