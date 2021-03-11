using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage;
using Domain;
using Storage.Implementation.Database;

namespace SystemOperation
{
    public abstract class SystemOperationBase
    {
        protected GenericRepository repository;
        public SystemOperationBase()
        {
            repository = new GenericRepository();
        }

        public void ExecuteTemplate(IEntity entity)
        {
            try
            {
                repository.OpenConnection();
                repository.BeginTransaction();
                ExecuteOperation(entity);
                repository.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                repository.Rollback();
                throw;
            }
            finally
            {
                repository.CloseConnection();
            }
        }

        protected abstract void ExecuteOperation(IEntity entity);
    }
}
