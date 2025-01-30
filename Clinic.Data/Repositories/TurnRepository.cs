using Clinic.Core.Models;
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
        public TurnRepository(DataContext context) : base(context) { }
    }
    
}


