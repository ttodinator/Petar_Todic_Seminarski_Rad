﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.AutomobilSO
{
    public class GetAllAutomobilSO : SystemOperationBase
    {
        public List<Automobil> Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(new Automobil()).Cast<Automobil>().ToList();
        }
    }
}
