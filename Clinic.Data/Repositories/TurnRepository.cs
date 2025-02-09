﻿using Clinic.Core.Models;
using Clinic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Data.Repositories
{
    public class TurnRepository : Repository<Turn>, ITurnRepository
    {
<<<<<<< HEAD
        public TurnRepository(DataContext context) : base(context) { }
=======
        private readonly DataContext _context;
        public TurnRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public List<Turn> GetList()
        {
            return _context.Turns.ToList();
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

            return existingTurn;
        }

        public void Delete(int id)
        {
            var existingTurn = GetById(id);
            if (existingTurn is not null)
            {
                _context.Turns.Remove(existingTurn);
            }
        }



>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
    }
    
}


