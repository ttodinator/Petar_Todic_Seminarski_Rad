using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.RentiranjeSO
{
    public class VratiRentiranjePoKriterijumuSO : SystemOperationBase
    {
        public List<Rentiranje> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            //Rentiranje r = (Rentiranje)entity;
            Result = repository.GetAllWhere(entity).Cast<Rentiranje>().ToList();
        }
    }
}
