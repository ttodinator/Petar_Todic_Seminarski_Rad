using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.MusterijaSO
{
    public class ZapamtiMusterijuSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            
            if (repository.Exist(entity))
            {
                throw new Exception("Musterija vec postoji u bazi");
                
            }
            else
            {

                repository.Save(entity);
            }
            //Musterija m = (Musterija)entity;
            //repository.Save(entity);
        }
    }
}
