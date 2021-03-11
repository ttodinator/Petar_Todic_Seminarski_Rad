using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.MusterijaSO
{
    public class SearchMusterijaJMBGSO : SystemOperationBase
    {
        public List<Musterija> Result { get; set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Musterija m = new Musterija();
            m = (Musterija)entity;
            m.WhereValue = $"{m.JMBG}";
            m.WhereCondition = "m.JMBG=";

            Result = repository.GetAllWhere(m).Cast<Musterija>().ToList();
        }
    }
}
