<<<<<<< HEAD
﻿using Clinic.Core.Models;
using Clinic.Core.Servicies;
using Clinic.Service;
=======
﻿using Clinic.Core.Servicies;
using Clinic.Core.Models;
>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
using Microsoft.AspNetCore.Mvc;
using Clinic.Service;

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
<<<<<<< HEAD
            var list =_doctorService.GetList();
           return Ok(list); 
=======
            var doctors = _doctorService.GetList();
            return Ok(doctors);
>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
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
<<<<<<< HEAD
        public void Post([FromBody] Doctor value)
        {
            _doctorService.Update(value);
=======
        public ActionResult Post([FromBody] Doctor doctor)
        {
            var newDoctor = _doctorService.Add(doctor);
            return Ok(newDoctor);

>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
        }

        // PUT api/<DoctorsController>/5
        // PUT api/<DoctorsController>/5
        [HttpPut("{id}")]
<<<<<<< HEAD
        public void Put( [FromBody] Doctor value)
        {
            _doctorService.Add( value);
=======
        public ActionResult Put(int id, [FromBody] Doctor doctor)
        {
            if (_doctorService.GetById(id) == null)
            {
                return NotFound(); // מחזיר 404 אם הרופא לא נמצא
            }
            var updatedDoctor = _doctorService.Update(doctor);
            return Ok(updatedDoctor);
>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
        }


        // DELETE api/<DoctorsController>/5
        [HttpDelete("{id}")]
<<<<<<< HEAD
        public void Delete(Doctor doctor)
        {
            _doctorService.Delete(doctor);
=======
        public ActionResult Delete(int id)
        {
            _doctorService.Delete(id);
            return Ok();
>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
        }
    }
}
