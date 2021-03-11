using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.RentiranjeSO
{
    public class SearchRentiranjeImeSO : SystemOperationBase
    {
        public List<Rentiranje> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Rentiranje r = (Rentiranje)entity;
            r.WhereValue = r.Musterija.Ime;
            r.WhereCondition = "m.Ime=";
            Result = repository.GetAllWhere(r).Cast<Rentiranje>().ToList();
        }
    }
}
