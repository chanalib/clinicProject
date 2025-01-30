using Clinic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Diagnostics;

namespace Clinic.Data
{
    public class DataContext: DbContext
    {
<<<<<<< HEAD
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Patient> patients { get; set; }
        public DbSet<Turn> turns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=My_db");
            optionsBuilder.LogTo(messege => Debug.WriteLine(messege));
=======
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
>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
        }
        //public DataContext(
        //{
        //    Advertisers = new List<Advertiser> { new Advertiser { Id = 1, Id_product = 1, Kind_Advertiser = "old", Name = "Chaim",Status="ective" } };
        //    Customers = new List<Customer> { new Customer { Id = 1, Name = "Nomi", IsActive = true, Mail = "1@gmail.com" } };
        //    Products = new List<Product> { new Product { Id = 1, Description = "small cupboard", Price = 150, Status = "by using 5 years" } };
        //}
    }
}
