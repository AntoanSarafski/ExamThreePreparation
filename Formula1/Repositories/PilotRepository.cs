using Formula1.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Formula1.Repositories
{
    public class PilotRepository<IPilot> : IRepository<IPilot>
    {
        public IReadOnlyCollection<IPilot> Models => throw new NotImplementedException();

        public void Add(IPilot model)
        {
            throw new NotImplementedException();
        }

        public IPilot FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Remove(IPilot model)
        {
            throw new NotImplementedException();
        }
    }
}
