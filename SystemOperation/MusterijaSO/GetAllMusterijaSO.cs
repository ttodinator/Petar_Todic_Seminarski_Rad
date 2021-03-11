using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.MusterijaSO
{
    public class GetAllMusterijaSO : SystemOperationBase
    {

        public List<Musterija> Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(new Musterija()).Cast<Musterija>().ToList();
        }
    }
}
