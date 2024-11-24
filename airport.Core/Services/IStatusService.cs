﻿using airport.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airport.Core.Services
{
    public interface IStatusService
    {
        public List<Status> GetList();

        public Status GetById(int id);
    }
}
