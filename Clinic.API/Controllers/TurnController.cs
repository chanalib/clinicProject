using Clinic.Core.Models;
using Clinic.Core.Servicies;
using Clinic.Service;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnController : ControllerBase
    {
        private readonly IDoctorService _turnService;
        public TurnController(IDoctorService doctorService)
        {
            _turnService = doctorService;
        }
        // GET: api/<DoctorsController>
        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
           return _turnService.GetList(); 
        }

        // GET api/<DoctorsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
