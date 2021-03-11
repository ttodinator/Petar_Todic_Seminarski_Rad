using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.MusterijaSO
{
    public class AddMusterijaSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            Musterija m = (Musterija)entity;
            repository.Save(m);
        }
    }
}
