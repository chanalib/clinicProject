using Clinic.Core.Models;
using Clinic.Core.Servicies;
using Clinic.Service;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;
        public PatientController(IPatientService contex)
        {
            _patientService = contex;
        }
        // GET: api/<DoctorsController>
        [HttpGet]
        public ActionResult Get()
        {
            var list = _patientService.GetList();
            return Ok(list);
        }

        // GET api/<DoctorsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var patient = _patientService.GetById(id);
            return Ok(patient);
        }

        // POST api/<DoctorsController>
        [HttpPost]
        public void Post([FromBody] Patient value)
        {
            _patientService.AddValue(value);
        }

        // PUT api/<DoctorsController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Patient value)
        {
            _patientService.Update(value);
        }

        // DELETE api/<DoctorsController>/5
        [HttpDelete("{id}")]
        public void Delete(Patient patient)
        {
            _patientService.Delete(patient);
        }
    }
}
