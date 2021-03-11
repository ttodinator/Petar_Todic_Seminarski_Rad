using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.AutomobilSO
{
    public class DeleteAutomobilSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            Automobil a = (Automobil)entity;
            a.WhereCondition = "BrojSasije=";
            a.WhereValue = $"'{a.BrojSasije}'";
            repository.Delete(a);
        }
    }
}
