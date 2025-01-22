using Clinic.Core.Servicies;
using Clinic.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Clinic.Service;

namespace Clinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorService _doctorService;
        public DoctorsController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }
        // GET: api/<DoctorsController>
        [HttpGet]
        public ActionResult Get()
        {
            var doctors = _doctorService.GetList();
            return Ok(doctors);
        }

        // GET api/<DoctorsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var doctor = _doctorService.GetById(id);
            return Ok(doctor);
        }

        // POST api/<DoctorsController>
        [HttpPost]
        public ActionResult Post([FromBody] Doctor doctor)
        {
            var newDoctor = _doctorService.Add(doctor);
            return Ok(newDoctor);

        }

        // PUT api/<DoctorsController>/5
        // PUT api/<DoctorsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Doctor doctor)
        {
            if (_doctorService.GetById(id) == null)
            {
                return NotFound(); // מחזיר 404 אם הרופא לא נמצא
            }
            var updatedDoctor = _doctorService.Update(doctor);
            return Ok(updatedDoctor);
        }


        // DELETE api/<DoctorsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _doctorService.Delete(id);
            return Ok();
        }
    }
}
