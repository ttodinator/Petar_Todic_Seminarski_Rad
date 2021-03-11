using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.RentiranjeSO
{
    public class SearchRentiranjePrezimeSO : SystemOperationBase
    {
        public List<Rentiranje> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Rentiranje r = (Rentiranje)entity;
            r.WhereValue = r.Musterija.Prezime;
            r.WhereCondition = "m.Prezime=";
            Result = repository.GetAllWhere(r).Cast<Rentiranje>().ToList();
        }
    }
}
