using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseBroker;

namespace Storage.Implementation.Database
{
    public class GenericRepository : IGenericRepository
    {

        private Broker broker = new Broker();
        public void BeginTransaction()
        {
            broker.BeginTransaction();
        }

        public void CloseConnection()
        {
            broker.CloseConnection();
        }

        public void Commit()
        {
            broker.Commit();
        }

        public void Delete(IEntity e)
        {
            broker.Delete(e);
        }

        public List<IEntity> GetAll(IEntity e)
        {
            return broker.GetAll(e);
        }

        public List<IEntity> GetAllWhere(IEntity e)
        {
            return broker.GetAllWhere(e);
        }

        public int GetNewId(IEntity e)
        {
            return broker.GetNewId(e);
        }

        public void OpenConnection()
        {
            broker.OpenConnection();
        }

        public void Rollback()
        {
            broker.Rollback();
        }

        public void Save(IEntity entity)
        {
            broker.Save(entity);
        }

        public void Update(IEntity entity)
        {
            broker.Update(entity);
        }

        public bool Exist(IEntity entity)
        {
            return broker.Exist(entity);
        }
    }
}
