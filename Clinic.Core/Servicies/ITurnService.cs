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
<<<<<<< HEAD
        IEnumerable<Turn> GetList();
        Turn GetById(int id);
        void AddValue(Turn turn);
        void Update(Turn turn);
        void Delete(Turn turn);
=======
        List<Turn> GetList();

        Turn? GetById(int id);

        Turn Add(Turn user);

        Turn Update(Turn user);

        void Delete(int id);
>>>>>>> 0fcec3393a653e385684a4c100f716a684bebdb5
    }
}
