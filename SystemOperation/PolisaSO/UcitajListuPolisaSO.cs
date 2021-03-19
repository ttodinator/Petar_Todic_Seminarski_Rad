using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.PolisaSO
{
    public class UcitajListuPolisaSO : SystemOperationBase
    {
        public List<Polisa> Result = new List<Polisa>();
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(new Polisa()).Cast<Polisa>().ToList();
        }
    }
}
