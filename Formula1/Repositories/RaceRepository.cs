﻿using Formula1.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Formula1.Repositories
{
    public class RaceRepository<IRace> : IRepository<IRace>
    {
        public IReadOnlyCollection<IRace> Models => throw new NotImplementedException();

        public void Add(IRace model)
        {
            throw new NotImplementedException();
        }

        public IRace FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Remove(IRace model)
        {
            throw new NotImplementedException();
        }
    }
}
