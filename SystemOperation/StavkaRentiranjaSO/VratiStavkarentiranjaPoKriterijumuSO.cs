using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.StavkaRentiranjaSO
{
    public class VratiStavkarentiranjaPoKriterijumuSO : SystemOperationBase
    {

        public List<StavkaRentiranja> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            StavkaRentiranja sr = (StavkaRentiranja)entity;
            sr.WhereCondition = "sr.RentiranjeID=";
            sr.WhereValue = sr.Rentiranje.Id.ToString();
            Result = repository.GetAllWhere(sr).Cast<StavkaRentiranja>().ToList();
        }
    }
}
