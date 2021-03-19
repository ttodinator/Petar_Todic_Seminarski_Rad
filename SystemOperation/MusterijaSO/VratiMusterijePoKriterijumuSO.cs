using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.MusterijaSO
{
    public class VratiMusterijePoKriterijumuSO : SystemOperationBase
    {

        public List<Musterija> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Musterija m = (Musterija)entity;
            Result= repository.GetAllWhere(m).Cast<Musterija>().ToList();
        }
    }
}
