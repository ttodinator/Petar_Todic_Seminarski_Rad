using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.RentiranjeSO
{
    public class UpdateRentiranjeSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            Rentiranje r = (Rentiranje)entity;
            r.WhereCondition = "ID=";
            r.WhereValue = $"{r.Id}";
            r.UpdateText = $"JMBG='{r.Musterija.JMBG}',Datum='{r.Datum.ToString("MM/dd/yyyy")}',UkupnaCena={CommaConversion(r.UkupnaCena.ToString())}";
            repository.Update(r);
            for (int i = 0; i < r.StavkeRentiranja.Count; i++)
            {
                r.StavkeRentiranja[i].Rentiranje = r;
                repository.Save(r.StavkeRentiranja[i]);
            }

        }

        private string CommaConversion(string s)
        {
            if (s.Contains(","))
            {
                return s.Replace(",", ".");
            }
            return s;
        }
    }
}
