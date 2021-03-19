using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.MusterijaSO
{
    public class IzmeniMusterijuSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            Musterija m = (Musterija)entity;
            m.WhereCondition = "JMBG=";
            m.WhereValue = $"'{m.JMBG}'";
            m.UpdateText = $"Ime='{m.Ime}',Prezime='{m.Prezime}', BrojTelefona='{m.BrojTelefona}', DatumRodjenja='{m.DatumRodjenja.ToString("MM/dd/yyyy")}'";
            repository.Update(m);
        }
    }
}
