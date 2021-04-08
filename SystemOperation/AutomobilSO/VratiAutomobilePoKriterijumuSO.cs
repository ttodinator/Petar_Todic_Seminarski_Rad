using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.AutomobilSO
{
    public class VratiAutomobilePoKriterijumuSO : SystemOperationBase
    {
        public List<Automobil> Result { get; set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            //Automobil a = (Automobil)entity;
            Result = repository.GetAllWhere(entity).Cast<Automobil>().ToList();
        }
    }
}
