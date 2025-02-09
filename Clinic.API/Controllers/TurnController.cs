﻿using Clinic.Core.Models;
using Clinic.Core.Servicies;
using Clinic.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnController : ControllerBase
    {
        private readonly ITurnService _turnService;
        public TurnController(ITurnService contex)
        {
            _turnService = contex;
        }
        // GET: api/<DoctorsController>
        [HttpGet]
        public ActionResult Get()
        {
            var list = _turnService.GetList();
            return Ok(list);
        }

        // GET api/<DoctorsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var turn = _turnService.GetById(id);
            return Ok(turn);
        }

        // POST api/<DoctorsController>
        [HttpPost]
        public void Post([FromBody] Turn value)
        {
            _turnService.AddValue(value);
        }

        // PUT api/<DoctorsController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Turn value)
        {
            _turnService.Update(value);
        }

        // DELETE api/<DoctorsController>/5
        [HttpDelete]
        public void Delete(Turn turn)
        {
            _turnService.Delete(turn);
        }
    }
}
