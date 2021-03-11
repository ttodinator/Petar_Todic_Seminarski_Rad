using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperation.MusterijaSO
{
    public class SearchMusterijaIme:SystemOperationBase
    {
        public List<Musterija> Result { get; set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Musterija m = new Musterija() ;
            m = (Musterija)entity;
            m.WhereValue = m.Ime;
            m.WhereCondition = "m.Ime=";
            
            Result = repository.GetAllWhere(m).Cast<Musterija>().ToList();
        }
    }
}
