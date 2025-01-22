using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Models
{
    internal class Turn
    {
        public int Id { get; set; }
        public DateTime dateTime { get; set; }
        public Patient patient { get; set; }
        public Doctor doctor { get; set; }
    }
}
