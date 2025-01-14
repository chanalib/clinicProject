using Clinic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.NewFolder
{
    internal interface IDoctorService
    {
       // List<Doctor> getAll();
        IEnumerable<Doctor> GetAll(); // ודא שהפונקציה מוגדרת כאן


    }
}
 