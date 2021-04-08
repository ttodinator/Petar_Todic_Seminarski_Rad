using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.ModelSO
{
    public class VratiListuModelaSO : SystemOperationBase
    {
        public List<Model> Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(entity).Cast<Model>().ToList();
        }
    }
}
