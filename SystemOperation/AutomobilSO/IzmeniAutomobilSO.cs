﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.AutomobilSO
{
    public class IzmeniAutomobilSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
                /*Automobil a = (Automobil)entity;
                a.WhereCondition = "BrojSasije=";
                a.WhereValue = $"'{a.BrojSasije}'";
                a.UpdateText = $"Registracija='{a.Registracija}',GodinaProizvodnje={a.GodinaProizvodnje},CenaPoDanu={CommaConversion(a.CenaPoDanu.ToString())},ModelID={a.Model.Id}";
                */
            repository.Update(entity);
        }
    }
}
