using Clinic.Core.Models;
using Clinic.Service;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private static List<Patient> patients = new List<Patient> { new Patient { Id = 1, Name = "User Name", Email = "hi@email.com" ,Adress="bney brak", Age=25} };
      //  private readonly IDoctorService _patientService;
        //public PatientController(IDoctorService doctorService)
        //{
        //    _patientService = doctorService;
        //}
        // GET: api/<DoctorsController>
        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            return patients;
        }

        // GET api/<DoctorsController>/5
        [HttpGet("{id}")]
        public ActionResult  Get(int id)
        {
            var patient = patients.Find(u => u.Id == id);
            if (patient is null)

                return NotFound();

            return Ok(patient);
        }

        // POST api/<DoctorsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DoctorsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DoctorsController>/5
        [HttpGet("{id}/DateTime")]
        public void getTurnToday(int id)//פונקציה שמחזירה אם יש למטופל זה תור היום
        {

        }
    }
}
