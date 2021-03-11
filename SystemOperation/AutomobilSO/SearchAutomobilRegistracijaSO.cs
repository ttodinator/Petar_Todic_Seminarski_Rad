using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.AutomobilSO
{
    public class SearchAutomobilRegistracijaSO : SystemOperationBase
    {
        public List<Automobil> Result { get; set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Automobil a = (Automobil)entity;
            a.WhereValue = a.Registracija;
            a.WhereCondition = "a.Registracija=";
            Result = repository.GetAllWhere(a).Cast<Automobil>().ToList();
        }
    }
}
