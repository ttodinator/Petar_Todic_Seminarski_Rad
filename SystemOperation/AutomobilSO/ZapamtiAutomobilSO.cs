using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.AutomobilSO
{
    public class ZapamtiAutomobilSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {

            Automobil a = (Automobil)entity;
            string k = CommaConversion(a.CenaPoDanu.ToString());
            a.InsertValues = $"'{a.BrojSasije}','{a.Registracija}',{a.GodinaProizvodnje},{k},{a.Model.Id}";
            repository.Save(a);
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
