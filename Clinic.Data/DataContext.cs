using Clinic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Data
{
    public class DataContext
    {
        public List<Doctor> Doctors { get; set; }
        public DataContext() 
        { 
            Doctors = new List<Doctor>();
            Doctors.Add(new Doctor { Id=1,Name="aviv",Email="a@gmail.com",Password="1"});
        }
    }
}
