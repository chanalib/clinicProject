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
<<<<<<< HEAD
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

=======
<<<<<<< HEAD

=======
>>>>>>> 6a29c17589fe23619cd948fe2e256f1b864d1a7f
>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
    }
}
