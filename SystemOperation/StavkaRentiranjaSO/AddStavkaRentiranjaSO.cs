using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.StavkaRentiranjaSO
{
    public class AddStavkaRentiranjaSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            StavkaRentiranja sr = (StavkaRentiranja)entity;
            repository.Save(sr);
        }
    }
}
