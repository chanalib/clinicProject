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
<<<<<<< HEAD
        public DataContext(DbContextOptions<DataContext> options)
        : base(options) { }
        public DbSet<Doctor> Doctors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocaldb;Database=my_db;Trusted_Connection=True;MultipleActiveResultSets=true");
=======
        public List<Doctor> Doctors { get; set; }
        public DataContext() 
        { 
            Doctors = new List<Doctor>();
            Doctors.Add(new Doctor { Id=1,Name="aviv",Email="a@gmail.com",Password="1"});
>>>>>>> 6a29c17589fe23619cd948fe2e256f1b864d1a7f
        }
    }
}
