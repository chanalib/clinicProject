using Clinic.Core.Models;
using Clinic.Core.Servicies;
using Clinic.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Service
{
    public class TurnService : ITurnService
    {
        private readonly IRepositoryManager _turnRepository;
        public TurnService(IRepositoryManager turnRepository)
        {
            _turnRepository = turnRepository;
        }
        public IEnumerable<Turn> GetList()
        {
            return _turnRepository.turns.GetAll();
        }
        public Turn GetById(int id)
        {
            return _turnRepository.turns.GetById(id);
        }
        public void AddValue(Turn turn)
        {
            _turnRepository.turns.Add(turn);
            _turnRepository.Save();
        }
        public void Update(Turn turn)
        {
            _turnRepository.turns.Update(turn);
            _turnRepository.Save();
        }
        public void Delete(Turn turn)
        {
            _turnRepository.turns.Delete(turn);
            _turnRepository.Save();
        }

    }
}
