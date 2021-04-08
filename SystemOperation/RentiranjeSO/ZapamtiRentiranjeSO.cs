using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperation.StavkaRentiranjaSO;

namespace SystemOperation.RentiranjeSO
{
    public class ZapamtiRentiranjeSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            Rentiranje r = (Rentiranje)entity;
            //string k = CommaConversion(r.UkupnaCena.ToString());
            //r.InsertValues= $"'{r.Musterija.JMBG}','{r.Datum.ToString("MM/dd/yyyy")}',{k}";
            repository.Save(entity);
            r.Id = repository.GetNewId(entity);
            for (int i = 0; i < r.StavkeRentiranja.Count; i++)
            {
                r.StavkeRentiranja[i].Rentiranje = r;
                repository.Save(r.StavkeRentiranja[i]);
            }
            
        }
    }
}
