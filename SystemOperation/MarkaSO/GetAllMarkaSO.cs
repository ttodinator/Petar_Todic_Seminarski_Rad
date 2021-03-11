using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperation.MarkaSO
{
    public class GetAllMarkaSO:SystemOperationBase
    {
        public List<Marka> Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(new Marka()).Cast<Marka>().ToList();
        }
    }
}
