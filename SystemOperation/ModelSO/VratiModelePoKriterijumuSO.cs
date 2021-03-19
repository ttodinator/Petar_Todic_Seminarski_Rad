using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.ModelSO
{
    public class VratiModelePoKriterijumuSO : SystemOperationBase
    {
        public List<Model> Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Model m = (Model)entity;
            entity.WhereValue = m.Marka.Naziv;
            Result = repository.GetAllWhere((Model)entity).Cast<Model>().ToList();
        }
    }
}
