using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.StavkaRentiranjaSO
{
    public class IzbrisiStavkaRentiranjaSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            StavkaRentiranja sr = (StavkaRentiranja)entity;
            sr.WhereCondition = "ID=";
            sr.WhereValue = $"{sr.Id}";
            repository.Delete(sr);
        }
    }
}
