﻿using Clinic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Repositories
{
    public interface IPatientRepository
    {
        List<Patient> GetList();

        Patient? GetById(int id);

        Patient Add(Patient user);

        Patient Update(Patient user);

        void Delete(int id);
    }
}
