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
        List<Turn> GetList();

        Turn? GetById(int id);

        Turn Add(Turn user);

        Turn Update(Turn user);

        void Delete(int id);
    }
}
