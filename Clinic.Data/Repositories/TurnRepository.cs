using Clinic.Core.Models;
using Clinic.Core.Repositories;
using Itinero.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Data.Repositories
{
    public class TurnRepository : Repository<Turn>, ITurnRepository
    {
        private readonly DataContext _context;
        public TurnRepository(DataContext context)
        {
            _context = context;
        }

        public List<Turn> GetAll()
        {
            return _context.Turns;
        }

        public Turn? GetById(int id)
        {
            return _context.Turns.FirstOrDefault(x => x.Id == id);
        }
        public Turn Add(Turn user)
        {
            _context.Turns.Add(user);
            return user;
        }

        public Turn Update(Turn p)
        {
            var existingTurn = GetById(p.Id);
            if (existingTurn is null)
            {
                throw new Exception("Turn not found");
            }
            existingTurn.dateTime = p.dateTime;
            existingTurn.doctor = p.doctor;
            existingTurn.patient = p.patient;
            existingTurn.Age = p.Age;

            return existingTurn;
        }

        public void Delete(int id)
        {
            var existingTurn = GetById(id);
            if (existingTurn is not null)
            {
                _context.Patients.Remove(existingTurn);
            }
        }



    }
}
