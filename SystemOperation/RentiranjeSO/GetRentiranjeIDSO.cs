using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.RentiranjeSO
{
    public class GetRentiranjeIDSO : SystemOperationBase
    {
        public int Result { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetNewId((Rentiranje)entity);
        }
    }
}
