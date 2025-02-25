﻿using airport.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airport.Core.Repositories
{
    public interface IAirplaneRepository
    {
        public List<Airplane> GetAll();

        public Airplane GetById(int id);
    }
}
