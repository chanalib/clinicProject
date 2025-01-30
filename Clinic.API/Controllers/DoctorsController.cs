using Clinic.Core.Models;
using Clinic.Core.Servicies;
using Clinic.Service;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorService _doctorService;
        public DoctorsController(IDoctorService contex)
        {
            _doctorService = contex;
        }
        // GET: api/<DoctorsController>
        [HttpGet]
        public ActionResult Get()
        {
            var list =_doctorService.GetList();
           return Ok(list); 
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
        public void Post([FromBody] Doctor value)
        {
            _doctorService.Update(value);
        }

        // PUT api/<DoctorsController>/5
        [HttpPut("{id}")]
        public void Put( [FromBody] Doctor value)
        {
            _doctorService.Add( value);
        }

        // DELETE api/<DoctorsController>/5
        [HttpDelete("{id}")]
        public void Delete(Doctor doctor)
        {
            _doctorService.Delete(doctor);
        }
    }
}
