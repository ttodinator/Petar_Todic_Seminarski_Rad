using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.RentiranjeSO
{
    public class SearchRentiranjeDatumSO : SystemOperationBase
    {
        public List<Rentiranje> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Rentiranje r = (Rentiranje)entity;
            r.WhereValue = r.Datum.ToString("MM/dd/yyyy");
            r.WhereCondition = "r.Datum=";
            Result = repository.GetAllWhere(r).Cast<Rentiranje>().ToList();
        }
    }
}
