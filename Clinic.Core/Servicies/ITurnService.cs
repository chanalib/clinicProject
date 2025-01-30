using Clinic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Servicies
{
    public interface ITurnService
    {
        IEnumerable<Turn> GetList();
        Turn GetById(int id);
        void AddValue(Turn turn);
        void Update(Turn turn);
        void Delete(Turn turn);
    }
}
